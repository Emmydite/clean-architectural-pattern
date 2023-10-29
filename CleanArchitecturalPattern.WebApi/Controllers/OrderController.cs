using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CleanArchitecturalPattern.Application.Interfaces.Services;
using CleanArchitecturalPattern.Domain.Entities;
using CleanArchitecturalPattern.WebApi.Models;

namespace CleanArchitecturalPattern.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<IActionResult> AddOrder(OrderModel model)
        {
            try
            {
                var order = new Order
                {
                    ProductId  = model.ProductId,
                    CustomerId = model.CustomerId,
                    OrderDate = model.OrderDate,
                    OrderShippedDate = model.OrderShippedDate,
                    Status = model.Status,
                    Items = model.Items
                };

                var createOrder = _orderService.AddOrder(order);

                return CreatedAtAction(nameof(AddOrder), new { Id = order.OrderId }, createOrder);
            }
            catch (Exception ex) 
            {
                throw ex;
            } 
        }

        [HttpGet]
        public async Task<IActionResult> GetOrder(Guid id)
        {
            try
            {
                var order = await _orderService.GetOrderById(id);

                return Ok(order);
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public async Task<IActionResult> GetOrders()
        {
            try
            {
                var orders = await _orderService.GetAllOrders();

                return Ok(orders);
            }
            catch (Exception ex) 
            {
                throw ex;
            } 
        }

        public IActionResult DeleteOrder(Guid id)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
