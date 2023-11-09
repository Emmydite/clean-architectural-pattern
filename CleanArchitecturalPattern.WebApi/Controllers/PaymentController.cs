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

        public IActionResult AddPayment(PaymentModel model)
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
                var createPayment = _paymentService.AddPayment(payment);
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
    }
}
