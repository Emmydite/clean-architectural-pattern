using CleanArchitecturalPattern.Application.Interfaces.Repositories;
using CleanArchitecturalPattern.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecturalPattern.Infrastructure.Data.Repositories
{
    public class PaymentRepository : SharedRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<Payment> GetPaymentByOrderId(Guid orderId)
        {
            var result = await _appDbContext.Payments
                                            .Where(e => e.OrderId == orderId)
                                            .FirstOrDefaultAsync();

            return result;
        }

        public async Task<IEnumerable<Payment>> GetPaymentsByCustomerId(Guid customerId)
        {
            var result = await _appDbContext.Payments
                                            .Where(e => e.CustomerId == customerId)
                                            .ToListAsync();

            return result;
        }
    }
}
