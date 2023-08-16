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
                var result = await _orderRepository.SaveChanges();

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteOrder(Guid id)
        {
            try
            {
                var order = _orderRepository.GetByIdAsync(id)
                                            .GetAwaiter()
                                            .GetResult();

                if (order != null)
                {
                    _orderRepository.Delete(order);
                    _orderRepository.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UpdateOrder(Order order)
        {
            try
            {
                _orderRepository.Update(order);
                var result = await _orderRepository.SaveChanges();

                return result == 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<Order> GetOrderById(Guid id)
        {
            try
            {
                var order = _orderRepository.GetByIdAsync(id);
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
    }
}
