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
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<int> AddCustomer(Customer customer)
        {
            await _customerRepository.AddAsync(customer);
            var result = await _customerRepository.SaveChanges();
            return result;
        }

        public void DeleteCustomer(Guid id)
        {
            var customer = _customerRepository.GetByIdAsync(id).GetAwaiter().GetResult();
            if (customer != null)
            {
                _customerRepository.Delete(customer);
                _customerRepository.SaveChanges();
            }
        }

        public void UpdateCustomer(Customer customer)
        {
            _customerRepository.Update(customer);
            _customerRepository.SaveChanges();
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            var result = _customerRepository.GetAllAsync();
        }
    }
}
