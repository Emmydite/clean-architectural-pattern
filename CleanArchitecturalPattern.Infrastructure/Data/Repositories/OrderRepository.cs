using CleanArchitecturalPattern.Application.Interfaces.Repositories;
using CleanArchitecturalPattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecturalPattern.Infrastructure.Data.Repositories
{
    public class OrderRepository : SharedRepository<Order>, IOrderRepository
    {
        public OrderRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }

        public Task<IEnumerable<Order>> GetCustomerOrdersById(Guid customerId)
        {
            var result = _appDbContext.Orders.Where(e => e.CustomerId == customerId).ToList();

            return result;
        }
    }
}
