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
                };

                var createLineItem = await _lineItemService.AddLineItem(lineItem);

                return CreatedAtAction(nameof(AddLineItem), new { Id = createLineItem }, createLineItem);
            }
            catch (Exception ex) 
            {
                throw ex;
            } 
        }

        public async Task<IActionResult> GetLineItem(Guid id)
        {
            try
            {
                var lineItem = await _lineItemService.GetLineItem(id);

                return Ok(lineItem);
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public Task<IActionResult> GetLineItems()
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
