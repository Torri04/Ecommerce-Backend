using ASP.NET_API.Data;
using ASP.NET_API.Dtos;
using ASP.NET_API.Extensions;
using ASP.NET_API.Helpers;
using ASP.NET_API.Interfaces;
using ASP.NET_API.Model;
using ASP.NET_API.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace ASP.NET_API.Controller;

[ApiController]
[Route("api/shoppingcart")]
public class ShoppingCartController : ControllerBase
{
    private readonly IShoppingCartRepository _shoppingCartRepository;
    private readonly IMapper _mapper;

    public ShoppingCartController(IShoppingCartRepository shoppingCartRepository, IMapper mapper)
    {
        _shoppingCartRepository = shoppingCartRepository;
        _mapper = mapper;
    }

    [Authorize(Roles = "User")]
    [HttpGet("all")]
    public async Task<IActionResult> GetShoppingCarts()
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var userId = User.GetUserId();
        var shoppingCarts = await _shoppingCartRepository.GetAllAsync(userId);

        if (shoppingCarts == null)
            return NotFound();

        var getShoppingCartDto = shoppingCarts.Select(p => _mapper.Map<GetShoppingCartDto>(p));

        return Ok(getShoppingCartDto);
    }

    [Authorize(Roles = "User")]
    [HttpGet("{id:Guid}")]
    public async Task<IActionResult> GetShoppingCartById([FromRoute] Guid id)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var shoppingCart = await _shoppingCartRepository.GetByIdAsync(id);

        if (shoppingCart == null)
            return NotFound();

        var getShoppingCartDto = _mapper.Map<GetShoppingCartDto>(shoppingCart);

        return Ok(getShoppingCartDto);
    }

    [Authorize(Roles = "User")]
    [HttpPost]
    public async Task<IActionResult> PostShoppingCart([FromBody] PostShoppingCartDto postShoppingCartDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var userId = User.GetUserId();

        var shoppingCart = _mapper.Map<ShoppingCart>(postShoppingCartDto);

        shoppingCart.UserID = userId;

        shoppingCart = await _shoppingCartRepository.PostAsync(shoppingCart);

        var getShoppingCartDto = _mapper.Map<GetShoppingCartDto>(shoppingCart);

        return CreatedAtAction(nameof(GetShoppingCartById), new { id = getShoppingCartDto.ShoppingCartID }, getShoppingCartDto);
    }

    [Authorize(Roles = "User")]
    [HttpPut("{id:Guid}")]
    public async Task<IActionResult> PutShoppingCart([FromRoute] Guid id, [FromBody] PutShoppingCartDto putShoppingCartDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var shoppingCart = await _shoppingCartRepository.PutAsync(id, putShoppingCartDto);

        if (shoppingCart == null)
            return BadRequest("Shopping cart not found");

        var getShoppingCartDto = _mapper.Map<GetShoppingCartDto>(shoppingCart);

        return Ok(getShoppingCartDto);
    }

    [Authorize(Roles = "User")]
    [HttpDelete("{id:Guid}")]
    public async Task<IActionResult> DeleteShoppingCart([FromRoute] Guid id)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var shoppingCart = await _shoppingCartRepository.DeleteAsync(id);

        if (shoppingCart == null)
            return BadRequest("Shopping cart not found");

        return NoContent();
    }

}