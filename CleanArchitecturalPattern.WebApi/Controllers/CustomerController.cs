﻿using Microsoft.AspNetCore.Mvc;
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

        public IActionResult GetCustomer()
        {

        }
    }
}
