using CleanArchitecturalPattern.Domain.Entities;

namespace CleanArchitecturalPattern.Application.Interfaces.Services
{
    public interface ILineItemService
    {
        Task<LineItem> AddLineItem(LineItem lineItem);
        void DeleteLineItem(Guid id);
        bool UpdateLineItem(LineItem lineItem);
        Task<LineItem> GetLineItem(Guid id);
    }
}
