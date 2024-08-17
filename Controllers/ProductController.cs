using ASP.NET_API.Data;
using ASP.NET_API.Dtos;
using ASP.NET_API.Helpers;
using ASP.NET_API.Interfaces;
using ASP.NET_API.Model;
using ASP.NET_API.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_API.Controller;

[ApiController]
[Route("api/product")]
public class ProductController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IProductRepository _productRepository;
    private readonly IProductCategoryRepository _productCategoryRepository;
    private readonly IAzureBlobService _azureBlobService;


    public ProductController(IProductRepository productRepository, IMapper mapper, IProductCategoryRepository productCategoryRepository, IAzureBlobService azureBlobService)
    {
        _productRepository = productRepository;
        _mapper = mapper;
        _productCategoryRepository = productCategoryRepository;
        _azureBlobService = azureBlobService;
    }

    [HttpGet("all")]
    public async Task<IActionResult> GetProducts([FromQuery] ProductQuery query)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var products = await _productRepository.GetAllAsync(query);

        var productsDto = products.Select(p => _mapper.Map<GetProductDto>(p));

        return Ok(productsDto);
    }

    [HttpGet("{id:Guid}")]
    public async Task<IActionResult> GetProductsById([FromRoute] Guid id)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var product = await _productRepository.GetByIdAsync(id);

        if (product == null)
            return NotFound("Product does not exsist");

        var productDto = _mapper.Map<GetProductDto>(product);
        return Ok(productDto);
    }

    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> PostProduct([FromForm] PostProductDto postProductDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var product = _mapper.Map<Product>(postProductDto);

        var checkExsist = await _productCategoryRepository.CheckExistAsync(product.CategoryID);

        if (!checkExsist)
            return NotFound("Product Category does not esxist");

        product.ImageUrl = await _azureBlobService.UploadFileAsync(postProductDto.ProductImage, "product-images");

        product = await _productRepository.PostAsync(product);

        var baseProduct = await _productRepository.GetByIdAsync(product.ProductID);

        var productDto = _mapper.Map<GetProductDto>(baseProduct);

        return CreatedAtAction(nameof(GetProductsById), new { id = product.ProductID }, productDto);
    }

    [HttpPut("{id:Guid}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> PutProduct([FromRoute] Guid id, [FromForm] PutProductDto putProductDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var checkExsist = await _productCategoryRepository.CheckExistAsync(putProductDto.CategoryID);

        if (!checkExsist)
            return NotFound("Product Category does not esxist");

        var product = await _productRepository.PutAsync(id, putProductDto);

        if (product == null)
            return NotFound("Product does not exsist");

        var baseProduct = await _productRepository.GetByIdAsync(id);

        await _azureBlobService.UpdateFileAsync(putProductDto.ProductImage, baseProduct.ImageUrl, "product-images");

        var productDto = _mapper.Map<GetProductDto>(baseProduct);

        return Ok(productDto);
    }

    [HttpDelete("{id:Guid}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteProduct([FromRoute] Guid id)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var product = await _productRepository.DeleteAsync(id);

        if (product == null)
            return NotFound("Product does not exsist");

        await _azureBlobService.DeleteBlobAsync(product.ImageUrl, "product-images");
        return NoContent();
    }
}