using AutoMapper;
using CaseProject.BusinessLayer.Abstract;
using CaseProject.DtoLayer.Dtos.Order;
using CaseProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaseProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrderController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            var values = await _orderService.GetOrdersWithDetails();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderById(int id)
        {
            var value = await _orderService.TGetByIdAsync(id);
            return Ok(value);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var value = await _orderService.TGetByIdAsync(id);
            await _orderService.TDeleteAsync(value);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> AddOrder(CreateOrderDto createOrderDto)
        {
            var value = _mapper.Map<Order>(createOrderDto);
            await _orderService.TInsertAsync(value);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateOrder(UpdateOrderDto updateOrderDto)
        {
            var value=_mapper.Map<Order>(updateOrderDto);
            await _orderService.TUpdateAsync(value);
            return Ok();
        }
    }
}
