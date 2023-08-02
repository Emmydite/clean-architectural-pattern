using CleanArchitecturalPattern.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecturalPattern.Application.Services
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService()
        {

        }
    }
}
