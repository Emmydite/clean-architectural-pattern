using CleanArchitecturalPattern.Application.Interfaces.Repositories;
using CleanArchitecturalPattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecturalPattern.Infrastructure.Data.Repositories
{
    public class LineItemRepository : SharedRepository<LineItem>, ILineItemRepository
    {
        public LineItemRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }
    }
}
