using CleanArchitecturalPattern.Application.Interfaces.Repositories;
using CleanArchitecturalPattern.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace CleanArchitecturalPattern.Infrastructure.Data.Repositories
{
    public class OrderRepository : SharedRepository<Order>, IOrderRepository
    {
        public OrderRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<Order> GetCustomerOrdersById(Guid customerId)
        {
            var result = await _appDbContext.Orders
                                            .Include(p => p.Items)
                                            .FirstOrDefaultAsync(e => e.CustomerId == customerId);

            return result;
        }
    }
}
