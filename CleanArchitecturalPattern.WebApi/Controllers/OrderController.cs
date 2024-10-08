﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CleanArchitecturalPattern.Application.Interfaces.Services;
using CleanArchitecturalPattern.Domain.Entities;
using CleanArchitecturalPattern.WebApi.Models;

namespace CleanArchitecturalPattern.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<IActionResult> AddOrder(OrderModel model)
        {
            try
            {
                var order = new Order
                {
                    ProductId = model.ProductId,
                    CustomerId = model.CustomerId,
                    OrderDate = model.OrderDate,
                    OrderShippedDate = model.OrderShippedDate,
                    Status = model.Status
                };

                var createOrder = _orderService.AddOrder(order);

                return CreatedAtAction(nameof(AddOrder), new { Id = order.OrderId }, createOrder);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetOrder(Guid id)
        {
            try
            {
                var order = await _orderService.GetOrderById(id);

                return Ok(order);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            try
            {
                var orders = await _orderService.GetAllOrders();

                return Ok(orders);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public IActionResult DeleteOrder(Guid id)
        {
            try
            {
                _orderService.DeleteOrder(id);

                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOrder(OrderModel model)
        {
            try
            {
                bool success = false;
                var order = await _orderService.GetOrderById(model.OrderId);

                if (order != null)
                {
                    order.ProductId = model.ProductId;
                    order.CustomerId = model.CustomerId;
                    order.OrderDate = model.OrderDate;
                    order.OrderShippedDate = model.OrderShippedDate;
                    order.Status = model.Status;

                    success = await _orderService.UpdateOrder(order);
                }

                return Ok(success);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
