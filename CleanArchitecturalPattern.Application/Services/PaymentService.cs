﻿using CleanArchitecturalPattern.Application.Interfaces.Services;
using CleanArchitecturalPattern.Application.Interfaces.Repositories;
using CleanArchitecturalPattern.Domain.Entities;

namespace CleanArchitecturalPattern.Application.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;
        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<int> AddPayment(Payment payment)
        {
            try
            {
                await _paymentRepository.AddAsync(payment);

                var result = await _paymentRepository.SaveChanges();

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UpdatePayment(Payment payment)
        {
            try
            {
                _paymentRepository.Update(payment);
                var response = await _paymentRepository.SaveChanges();

                return response == 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeletePayment(Guid paymentId)
        {
            try
            {
                var payment = _paymentRepository.GetByIdAsync(paymentId)
                                                .GetAwaiter()
                                                .GetResult();
                if (payment != null)
                {
                    _paymentRepository.Delete(payment);
                    _paymentRepository.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Payment> GetPaymentById(Guid paymentId)
        {
            try
            {
                var payment = await _paymentRepository.GetByIdAsync(paymentId);

                return payment;
            }
            catch (Exception ex) 
            {
                throw ex;
            } 
        }

        public async Task<IEnumerable<Payment>> GetAllPayments()
        {
            try
            {
                var payments = await _paymentRepository.GetAllAsync();

                return payments;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Payment>> GetPaymentsByCustomerId(Guid customerId)
        {
            try
            {
                var paymentsData = await _paymentRepository.GetPaymentsByCustomerId(customerId);
                var customerPayments = paymentsData.ToList();

                return customerPayments;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Payment> GetPaymentsByOrderId(Guid orderId)
        {
            try
            {
                var paymentData = await _paymentRepository.GetPaymentByOrderId(orderId);

                return paymentData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
