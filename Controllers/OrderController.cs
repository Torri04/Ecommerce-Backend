using ASP.NET_API.Dtos;
using ASP.NET_API.Extensions;
using ASP.NET_API.Interfaces;
using ASP.NET_API.Model;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_API.Controller;

[Route("api/order")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly IOrderRepository _orderRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<OrderController> _logger;
    public OrderController(IOrderRepository orderRepository, IMapper mapper, ILogger<OrderController> logger)
    {
        _orderRepository = orderRepository;
        _mapper = mapper;
        _logger = logger;
    }

    //Admin
    [Authorize(Roles = "Admin")]
    [HttpGet("admin")]
    public async Task<IActionResult> GetAdminOrders()
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var orders = await _orderRepository.GetAllAsync();

        var ordersDto = orders.Select(p => _mapper.Map<GetOrderDto>(p));

        return Ok(ordersDto);
    }

    //User
    [Authorize(Roles = "User")]
    [HttpGet("user")]
    public async Task<IActionResult> GetUserOrders()
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var userId = User.GetUserId();

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var orders = await _orderRepository.GetAllAsync(userId);

        var ordersDto = orders.Select(p => _mapper.Map<GetOrderDto>(p));

        return Ok(ordersDto);
    }

    [Authorize(Roles = "User")]
    [HttpPost("user")]
    public async Task<IActionResult> PostOrders([FromBody] PostOrderDto postOrderDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var userId = User.GetUserId();

        var order = _mapper.Map<Order>(postOrderDto);

        order.UserID = userId;

        order = await _orderRepository.PostAsync(order);

        var orderDto = _mapper.Map<GetOrderDto>(order);

        return CreatedAtAction(nameof(GetOrderById), new { id = orderDto.OrderID }, orderDto);
    }

    [Authorize(Roles = "User")]
    [HttpPut("user/{id:Guid}")]
    public async Task<IActionResult> PutOrderItems([FromRoute] Guid id, [FromBody] PutOrderDto putOrderDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var order = await _orderRepository.PutOrderItemsAsync(id, putOrderDto);

        if (order == null)
            return BadRequest("Order not found");

        var orderDto = _mapper.Map<GetOrderDto>(order);

        return Ok(orderDto);
    }

    //Share
    [Authorize]
    [HttpGet("{id:Guid}")]
    public async Task<IActionResult> GetOrderById([FromRoute] Guid id)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var order = await _orderRepository.GetByIdAsync(id);

        if (order == null)
            return NotFound("Order not found");

        var orderDto = _mapper.Map<GetOrderDto>(order);

        return Ok(orderDto);
    }

    [Authorize]
    [HttpPut("orderstatus/{id:Guid}")]
    public async Task<IActionResult> PutOrderStatus([FromRoute] Guid id, [FromBody] string status)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var order = await _orderRepository.PutOrderStatusAsync(id, status);

        if (order == null)
            return NotFound("Order not found");

        var orderDto = _mapper.Map<GetOrderDto>(order);

        return Ok(orderDto);
    }
}