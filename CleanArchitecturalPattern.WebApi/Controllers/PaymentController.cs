using Microsoft.AspNetCore.Mvc;
using CleanArchitecturalPattern.Application.Interfaces.Services;
using CleanArchitecturalPattern.Domain.Entities;
using CleanArchitecturalPattern.WebApi.Models;

namespace CleanArchitecturalPattern.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost]
        public async Task<IActionResult> AddPayment(PaymentModel model)
        {
            try
            {
                var payment = new Payment
                {
                    CustomerId = model.CustomerId,
                    OrderId = model.OrderId,
                    PaymentDate = model.PaymentDate,
                    Amount = model.Amount,
                };

                var createPayment = await _paymentService.AddPayment(payment);

                return CreatedAtAction(nameof(AddPayment), new { Id = createPayment }, createPayment);
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetPayment(Guid id)
        {
            try
            {
                var payment = await _paymentService.GetPaymentById(id);

                return Ok(payment);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetPayments()
        {
            try
            {
                var payments = await _paymentService.GetAllPayments();

                return Ok(payments);
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        [HttpDelete]
        public IActionResult DeletePayment(Guid id)
        {
            try
            {
                _paymentService.DeletePayment(id);

                return Ok();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePayment(PaymentModel model)
        {
            try
            {
                var payment = await _paymentService.GetPaymentById(model.PaymentId);
                if (payment != null)
                {
                   payment.CustomerId = model.CustomerId;
                    payment.OrderId = model.OrderId;
                    payment.Amount = model.Amount;
                    payment.PaymentDate = model.PaymentDate;

                   await _paymentService.UpdatePayment(payment)
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
