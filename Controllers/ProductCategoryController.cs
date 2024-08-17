using ASP.NET_API.Data;
using ASP.NET_API.Dtos;
using ASP.NET_API.Interfaces;
using ASP.NET_API.Model;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_API.Controller;

[ApiController]
[Route("api/category")]
public class ProductCategoryController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IProductCategoryRepository _productCategoryRepository;

    public ProductCategoryController(IProductCategoryRepository productCategoryRepository, IMapper mapper)
    {
        _mapper = mapper;
        _productCategoryRepository = productCategoryRepository;
    }

    [HttpGet("all")]
    public async Task<IActionResult> Categories()
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var categories = await _productCategoryRepository.GetAllAsync();

        var categoriesDto = categories.Select(p => _mapper.Map<GetProductCategoryDto>(p));

        return Ok(categoriesDto);
    }

    [HttpGet("{id:Guid}")]
    public async Task<IActionResult> CategoryById([FromRoute] Guid id)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var category = await _productCategoryRepository.GetByIdAsync(id);

        if (category == null)
        {
            return NotFound("Product Category does not exsist");
        }

        var categoryDto = _mapper.Map<GetProductCategoryDto>(category);
        return Ok(categoryDto);
    }

    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> PostCategory([FromBody] PostProductCategoryDto postProductCategoryDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var productCategory = _mapper.Map<ProductCategory>(postProductCategoryDto);

        productCategory = await _productCategoryRepository.PostAsync(productCategory);

        var productCategoryDto = _mapper.Map<GetProductCategoryDto>(productCategory);

        return CreatedAtAction(nameof(CategoryById), new { id = productCategoryDto.ProductCategoryID }, productCategoryDto);
    }

    [HttpPut("{id:Guid}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> PutCategory([FromRoute] Guid id, [FromBody] PutProductCategoryDto putProductCategoryDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var productCategory = await _productCategoryRepository.PutAsync(id, putProductCategoryDto);

        if (productCategory == null)
            return NotFound("Product Category does not exsist");

        var productCategoryDto = _mapper.Map<GetProductCategoryDto>(productCategory);

        return Ok(productCategoryDto);

    }
    [HttpDelete("{id:Guid}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteCategory([FromRoute] Guid id)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var productCategory = await _productCategoryRepository.DeleteAsync(id);

        if (productCategory == null)
            return NotFound("Product Category does not exsist");

        return NoContent();
    }
}