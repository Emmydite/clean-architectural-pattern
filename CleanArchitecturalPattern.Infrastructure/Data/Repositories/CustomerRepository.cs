using CleanArchitecturalPattern.Application.Interfaces.Repositories;
using CleanArchitecturalPattern.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecturalPattern.Infrastructure.Data.Repositories
{
    public class CustomerRepository : SharedRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<Customer> GetCustomerByEmail(string customerEmail)
        {
            var result = await _appDbContext.Customers
                                      .Where(e => e.Email == customerEmail)
                                      .FirstOrDefaultAsync();

            return result;
        }
    }
}
