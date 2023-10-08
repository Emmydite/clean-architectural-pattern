using CleanArchitecturalPattern.Application.Interfaces.Services;
using CleanArchitecturalPattern.Application.Interfaces.Repositories;
using System;
using CleanArchitecturalPattern.Domain.Entities;
using CleanArchitecturalPattern.Application.DTOs;

namespace CleanArchitecturalPattern.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IPaymentRepository _paymentRepository;
        public CustomerService(ICustomerRepository customerRepository,
                               IPaymentRepository paymentRepository)
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
                var customer = _customerRepository.GetByIdAsync(id)
                                                  .GetAwaiter()
                                                  .GetResult();
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

        public async Task<bool> UpdateCustomer(Customer customer)
        {
            try
            {
                _customerRepository.Update(customer);
                var result = await _customerRepository.SaveChanges();

                return result == 1;
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

        public async Task<List<CustomerPaymentsDto>> CustomerPayments(Guid id)
        {
            try
            {
                var result = await _paymentRepository.GetPaymentsByCustomerId(id);

                var customer = await GetCustomer(id);

                var customerPayments = result.Select(e => new CustomerPaymentsDto
                {
                    CustomerId = id,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    PhoneNumber = customer.PhoneNumber,
                    Email = customer.Email,
                    OrderId = e.OrderId,
                    PaymentDate = e.PaymentDate,
                    Amount = e.Amount
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
