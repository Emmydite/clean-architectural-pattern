using CleanArchitecturalPattern.Domain.Entities;

namespace CleanArchitecturalPattern.Application.Interfaces.Services
{
    public interface ILineItemService
    {
        Task<int> AddLineItem(LineItem lineItem);
        void DeleteLineItem(Guid id);
        Task<bool> UpdateLineItem(LineItem lineItem);
        Task<LineItem> GetLineItem(Guid id);
    }
}
