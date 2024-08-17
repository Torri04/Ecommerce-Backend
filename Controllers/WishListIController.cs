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

namespace ASP.NET_API.Controller;

[ApiController]
[Route("api/wishlist")]
public class WishListController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IWishListRepository _wishListRepository;

    public WishListController(IWishListRepository wishListRepository, IMapper mapper)
    {
        _mapper = mapper;
        _wishListRepository = wishListRepository;
    }

    [Authorize(Roles = "User")]
    [HttpGet]
    public async Task<IActionResult> GetWishList()
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var userId = User.GetUserId();
        var wishList = await _wishListRepository.GetByIdAsync(userId);

        if (wishList == null)
            return Ok(new { });

        var wishListDto = _mapper.Map<GetWishListDto>(wishList);
        return Ok(wishListDto);
    }

    [Authorize(Roles = "User")]
    [HttpPost]
    public async Task<IActionResult> PostWishList([FromBody] List<Guid> productIDs)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var userId = User.GetUserId();

        var wishList = await _wishListRepository.PostAsync(userId, productIDs);

        var getWishListDto = _mapper.Map<GetWishListDto>(wishList);

        return CreatedAtAction(nameof(GetWishList), new { id = getWishListDto.UserID }, getWishListDto);
    }

    [Authorize(Roles = "User")]
    [HttpDelete]
    public async Task<IActionResult> DeleteWishListItem([FromBody] List<Guid> productIds)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var userId = User.GetUserId();

        var wishList = await _wishListRepository.DeleteAsync(userId, productIds);

        if (wishList == null)
            return NotFound();

        return NoContent();
    }
}