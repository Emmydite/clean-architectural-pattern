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

        [HttpPost]
        public async Task<IActionResult> AddCustomer(CustomerModel model)
        {
            try
            {
                var customer = new Customer
                {
                    Id = model.Id,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    PhoneNumber = model.PhoneNumber,
                    Email = model.Email,
                    Address1 = model.Address1,
                    Address2 = model.Address2,
                    Postcode = model.Postcode,
                    City = model.City,
                    Country = model.Country,
                };

                var createCustomer = await _customerService.AddCustomer(customer);

                return CreatedAtAction(nameof(AddCustomer), new {Id = customer.Id}, createCustomer);
            }
            catch (Exception ex) 
            {
                throw ex;
            }  
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomer(Guid id)
        {
            try
            {
                var customer = await _customerService.GetCustomer(id);

                return Ok(customer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            try
            {
                var customers = await _customerService.GetAllCustomers();

                return Ok(customers);
            }
            catch (Exception ex) 
            { 
                throw ex;
            } 
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCustomer(CustomerModel model)
        {
            try
            {
                bool success = false;
                var customer = await _customerService.GetCustomer(model.Id);

                if(customer != null)
                {
                    customer.FirstName = model.FirstName;
                    customer.LastName = model.LastName;
                    customer.Email = model.Email;
                    customer.PhoneNumber = model.PhoneNumber;
                    customer.Address1 = model.Address1;
                    customer.Address2 = model.Address2;
                    customer.City = model.City;
                    customer.Country = model.Country;

                    success = await _customerService.UpdateCustomer(customer);
                }

                return Ok(success);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public IActionResult DeleteCustomer(Guid id)
        {
            try
            {
                _customerService.DeleteCustomer(id);

                return Ok();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public IActionResult GetCustomerPayments()
        {
            try
            {

            }
            catch () 
            { 

            } 
        }
    }
}
