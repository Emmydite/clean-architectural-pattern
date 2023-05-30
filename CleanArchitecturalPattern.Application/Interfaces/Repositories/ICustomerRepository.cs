using CleanArchitecturalPattern.Domain.Entities;

namespace CleanArchitecturalPattern.Application.Interfaces.Repositories
{
    public interface ICustomerRepository : ISharedRepository<Customer>
    {
        Task<Customer> GetCustomerByEmail(string customerEmail);
    }
}
