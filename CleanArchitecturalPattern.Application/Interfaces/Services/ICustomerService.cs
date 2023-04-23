using CleanArchitecturalPattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecturalPattern.Application.Interfaces.Services
{
    public interface ICustomerService
    {
        Task<Customer> AddCustomer(Customer customer);
        Task<IEnumerable<Customer>> GetAllCustomers();
        Customer GetCustomer(Guid id);
    }
}
