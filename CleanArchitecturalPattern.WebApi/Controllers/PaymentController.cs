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

                }
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
    }
}
