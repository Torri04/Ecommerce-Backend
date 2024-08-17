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
[Route("api/review")]
public class ReviewController : ControllerBase
{
    private readonly IReviewRepository _reviewRepository;
    private readonly IMapper _mapper;

    public ReviewController(IReviewRepository reviewRepository, IMapper mapper)
    {
        _reviewRepository = reviewRepository;
        _mapper = mapper;
    }

    [HttpGet("{id:Guid}")]
    public async Task<IActionResult> GetReviews([FromRoute] Guid id)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var reviews = await _reviewRepository.GetByIdAsync(id);
        if (reviews == null)
            return NotFound();

        var reviewsDto = _mapper.Map<List<GetReviewDto>>(reviews);

        return Ok(reviewsDto);
    }

    [Authorize(Roles = "User")]
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] PostReviewDto postReviewDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var userId = User.GetUserId();

        var review = _mapper.Map<Review>(postReviewDto);

        review.UserID = userId;

        review = await _reviewRepository.PostAsync(review);

        var reviewDto = _mapper.Map<GetReviewDto>(review);

        return Ok(reviewDto);
    }

    [Authorize(Roles = "User")]
    [HttpPut("{id:Guid}")]
    public async Task<IActionResult> PutAsync([FromRoute] Guid id, [FromBody] PutReviewDto putReviewDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var userId = User.GetUserId();

        var review = await _reviewRepository.PutAsync(id, userId, putReviewDto);

        if (review == null)
            return NotFound();

        var reviewDto = _mapper.Map<GetReviewDto>(review);

        return Ok(reviewDto);
    }

    [Authorize(Roles = "User")]
    [HttpDelete("{id:Guid}")]
    public async Task<IActionResult> DeleteAsync([FromRoute] Guid id)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var userId = User.GetUserId();

        var review = await _reviewRepository.DeleteAsync(id, userId);

        if (review == null)
            return NotFound();

        return NoContent();
    }
}