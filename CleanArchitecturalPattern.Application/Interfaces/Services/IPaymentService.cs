using CleanArchitecturalPattern.Domain.Entities;

namespace CleanArchitecturalPattern.Application.Interfaces.Services
{
    public interface IPaymentService
    {
        Task<int> AddPayment(Payment payment);
        Task<bool> UpdatePayment(Payment payment);
        void DeletePayment(Guid paymentId);
        Task<Payment> GetPaymentById(Guid paymentId);
        Task<IEnumerable<Payment>> GetAllPayments();
        Task<List<Payment>> GetPaymentsByCustomerId(Guid customerId);
        Task<List<Payment>> GetPaymentsByOrderId(Guid productId);
    }
}
