using Microsoft.AspNetCore.Mvc;
using CleanArchitecturalPattern.Application.Interfaces.Services;
using CleanArchitecturalPattern.Domain.Entities;
using CleanArchitecturalPattern.WebApi.Models;

namespace CleanArchitecturalPattern.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult AddCustomer(CustomerModel model)
        {
            try
            {
                var customer = new Customer
                {

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
