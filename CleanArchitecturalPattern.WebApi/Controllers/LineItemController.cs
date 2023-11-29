using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CleanArchitecturalPattern.Application.Interfaces.Services;
using CleanArchitecturalPattern.Domain.Entities;
using CleanArchitecturalPattern.WebApi.Models;

namespace CleanArchitecturalPattern.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LineItemController : ControllerBase
    {
        private readonly ILineItemService _lineItemService;
        public LineItemController(ILineItemService lineItemService)
        {
            _lineItemService = lineItemService;
        }

        public async Task<IActionResult> AddLineItem(LineItemModel model)
        {
            try
            {
                var lineItem = new LineItem
                {
                    OrderId = model.OrderId,
                    ProductId = model.ProductId,
                    Quantity = model.Quantity,
                }
            }
            catch (Exception ex) 
            {
                throw ex;
            } 
        }
    }
}
