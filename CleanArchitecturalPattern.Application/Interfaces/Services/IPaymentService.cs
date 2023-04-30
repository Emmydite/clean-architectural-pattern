using CleanArchitecturalPattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecturalPattern.Application.Interfaces.Services
{
    public interface IPaymentService
    {
        Task<Payment> AddPayment(Payment payment);
        Task<bool> UpdatePayment(Payment payment);
        void DeletePayment(Guid paymentId);
        Payment GetPaymentById(Guid paymentId);
    }
}
