using CleanArchitecturalPattern.Domain.Entities;
using System;


namespace CleanArchitecturalPattern.Application.Interfaces.Services
{
    public interface IOrderService
    {
        Task<int> AddLineItem();
    }
}
