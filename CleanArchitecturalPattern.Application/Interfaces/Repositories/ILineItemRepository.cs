using CleanArchitecturalPattern.Domain.Entities;

namespace CleanArchitecturalPattern.Application.Interfaces.Repositories
{
    public interface ILineItemRepository : ISharedRepository<LineItem>
    {
        Task<IEnumerable<LineItem>> GetLineItemsByProductId(Guid productId);
    }
}
