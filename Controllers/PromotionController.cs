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
[Route("api/promotion")]
public class PromotionController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IPromotionRepository _promotionRepository;

    public PromotionController(IPromotionRepository promotionRepository, IMapper mapper)
    {
        _promotionRepository = promotionRepository;
        _mapper = mapper;
    }

    [HttpGet("all")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> GetPromotions()
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var promotions = await _promotionRepository.GetAllAsync();

        if (promotions == null)
            return NotFound();

        var promotionsDto = _mapper.Map<List<GetPromotionDto>>(promotions);
        return Ok(promotionsDto);
    }

    [HttpGet("{id:Guid}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> GetPromotionById([FromRoute] Guid id)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var promotion = await _promotionRepository.GetByIdAsync(id);

        if (promotion == null)
            return NotFound();

        var promotionDto = _mapper.Map<GetPromotionDto>(promotion);
        return Ok(promotionDto);
    }

    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> PostPromotion([FromBody] PostPromotionDto postPromotionDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var promotion = _mapper.Map<Promotion>(postPromotionDto);

        promotion = await _promotionRepository.PostAsync(promotion);

        var promotionDto = _mapper.Map<GetPromotionDto>(promotion);

        return CreatedAtAction(nameof(GetPromotionById), new { id = promotionDto.PromotionID }, promotionDto);
    }

    [HttpPut("{id:Guid}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> PutPromotion([FromRoute] Guid id, [FromBody] PutPromotionDto putPromotionDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var promotion = await _promotionRepository.PutAsync(id, putPromotionDto);

        if (promotion == null)
            return NotFound();

        var promotionDto = _mapper.Map<GetPromotionDto>(promotion);

        return Ok(promotionDto);
    }

    [HttpDelete("{id:Guid}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeletePromotion([FromRoute] Guid id)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var promotion = await _promotionRepository.DeleteAsync(id);

        if (promotion == null)
            return NotFound();

        return NoContent();
    }
}