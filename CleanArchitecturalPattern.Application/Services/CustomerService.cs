using CleanArchitecturalPattern.Application.Interfaces.Services;
using CleanArchitecturalPattern.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecturalPattern.Domain.Entities;

namespace CleanArchitecturalPattern.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IPaymentRepository _paymentRepository;
        public CustomerService(ICustomerRepository customerRepository, IPaymentRepository paymentRepository)
        {
            _customerRepository = customerRepository;
            _paymentRepository = paymentRepository;
        }

        public async Task<int> AddCustomer(Customer customer)
        {
            try
            {
                await _customerRepository.AddAsync(customer);
                var result = await _customerRepository.SaveChanges();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteCustomer(Guid id)
        {
            try
            {
                var customer = _customerRepository.GetByIdAsync(id).GetAwaiter().GetResult();
                if (customer != null)
                {
                    _customerRepository.Delete(customer);
                    _customerRepository.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public void UpdateCustomer(Customer customer)
        {
            try
            {
                _customerRepository.Update(customer);
                _customerRepository.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            try
            {
                var customers = await _customerRepository.GetAllAsync();

                return customers;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Customer> GetCustomer(Guid id)
        {
            try
            {
                var customer = await _customerRepository.GetByIdAsync(id);

                return customer;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Customer>> CustomerPayments(Guid id)
        {
            try
            {
                var result = await _paymentRepository.GetPaymentsByCustomerId(id);

                var customer = await GetCustomer(id);

                var customerPayments = result.Select(new Customer
                {
                    Id = id,
                    FirstName = customer.FirstName,
                }).ToList();

                return customerPayments;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
