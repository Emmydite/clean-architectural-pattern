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
                    Items = model.Items,
                };
            }
            catch (Exception ex) 
            {
                throw ex;
            } 
        }
    }
}
