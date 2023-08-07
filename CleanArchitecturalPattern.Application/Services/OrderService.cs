using CleanArchitecturalPattern.Application.Interfaces.Repositories;
using CleanArchitecturalPattern.Application.Interfaces.Services;
using CleanArchitecturalPattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanArchitecturalPattern.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<int> AddOrder(Order order)
        {
            try
            {
               await _orderRepository.AddAsync(order);
               await _orderRepository.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
