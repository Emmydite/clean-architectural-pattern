using CleanArchitecturalPattern.Domain.Entities;

namespace CleanArchitecturalPattern.Application.Interfaces.Repositories
{
    public interface IOrderRepository : ISharedRepository<Order>
    {
        Task<Order> GetCustomerOrdersById(Guid customerId);
    }
}
