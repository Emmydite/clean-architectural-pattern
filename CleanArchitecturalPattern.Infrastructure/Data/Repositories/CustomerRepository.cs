using CleanArchitecturalPattern.Application.Interfaces.Repositories;
using CleanArchitecturalPattern.Domain.Entities;
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

        public Task<IEnumerable<Customer>> GetCustomerByEmail(string customerEmail)
        {

        }
    }
}
