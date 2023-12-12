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

        public async Task<IActionResult> GetLineItems()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public IActionResult DeleteLineItem(Guid id) 
        {
            try
            {
                _lineItemService.DeleteLineItem(id);

                return Ok();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public async Task<IActionResult> UpdateLineItem(LineItemModel model)
        {
            try
            {
                var success = false;
                var lineItem = await _lineItemService.GetLineItem(model.Id);
                if (lineItem != null)
                {
                    lineItem.OrderId = model.OrderId;
                    lineItem.ProductId = model.ProductId;
                    lineItem.Quantity = model.Quantity;
                    lineItem.TotalPrice();

                    success = _lineItemService.UpdateLineItem(lineItem)
                }
                return Ok();
            }
            catch (Exception ex) 
            {
                throw ex;
            } 
        }
    }
}
