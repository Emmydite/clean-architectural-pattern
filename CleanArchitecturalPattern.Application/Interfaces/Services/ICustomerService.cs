using CleanArchitecturalPattern.Domain.Entities;

namespace CleanArchitecturalPattern.Application.Interfaces.Services
{
    public interface ICustomerService
    {
        Task<int> AddCustomer(Customer customer);
        void DeleteCustomer(Guid id);
        Task<bool> UpdateCustomer(Customer customer);
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer> GetCustomer(Guid id);
        Task<List<Customer>> CustomerPayments(Guid id);
    }
}
