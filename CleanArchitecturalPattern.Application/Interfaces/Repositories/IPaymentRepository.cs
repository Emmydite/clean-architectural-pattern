using CleanArchitecturalPattern.Domain.Entities;

namespace CleanArchitecturalPattern.Application.Interfaces.Repositories
{
    public interface IPaymentRepository : ISharedRepository<Payment>
    {
        Task<Payment> GetPaymentByOrderId(Guid orderId);
        Task<IEnumerable<Payment>> GetPaymentsByCustomerId(Guid customerId);
    }
}
