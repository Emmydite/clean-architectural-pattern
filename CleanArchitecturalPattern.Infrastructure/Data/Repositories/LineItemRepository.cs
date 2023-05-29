using CleanArchitecturalPattern.Application.Interfaces.Repositories;
using CleanArchitecturalPattern.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecturalPattern.Infrastructure.Data.Repositories
{
    public class LineItemRepository : SharedRepository<LineItem>, ILineItemRepository
    {
        public LineItemRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<IEnumerable<LineItem>> GetLineItemsByProductId(Guid productId)
        {
            var result = await _appDbContext.LineItems
                                            .Where(e => e.ProductId == productId)
                                            .ToListAsync();

            return result;
        }
    }
}
