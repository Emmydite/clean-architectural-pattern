using CleanArchitecturalPattern.Application.Interfaces.Repositories;
using CleanArchitecturalPattern.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecturalPattern.Infrastructure.Data.Repositories
{
    public class OrderRepository : SharedRepository<Order>, IOrderRepository
    {
        public OrderRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<IEnumerable<Order>> GetCustomerOrdersById(Guid customerId)
        {
            var result = await _appDbContext.Orders
                                            .Where(e => e.CustomerId == customerId)
                                            .ToListAsync();

            return result;
        }
    }
}
