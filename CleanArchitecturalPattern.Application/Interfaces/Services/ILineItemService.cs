using CleanArchitecturalPattern.Domain.Entities;
using System;

namespace CleanArchitecturalPattern.Application.Interfaces.Services
{
    public interface ILineItemService
    {
        Task<LineItem> AddLineItem(LineItem lineItem);
        void DeleteLineItem(Guid id);
    }
}
