using CleanArchitecturalPattern.Application.DTOs;
using CleanArchitecturalPattern.Domain.Entities;

namespace CleanArchitecturalPattern.Application.Interfaces.Services
{
    public interface ICustomerService
    {
        Task<int> AddCustomer(Customer customer);
        void DeleteCustomer(Guid id);
        void UpdateCustomer(Customer customer);
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer> GetCustomer(Guid id);
        Task<List<CustomerPaymentsDto>> CustomerPayments(Guid id);
    }
}
