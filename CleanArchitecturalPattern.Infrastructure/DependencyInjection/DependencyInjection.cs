﻿using CleanArchitecturalPattern.Application.Interfaces.Repositories;
using CleanArchitecturalPattern.Infrastructure.Data;
using CleanArchitecturalPattern.Infrastructure.Data.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace CleanArchitecturalPattern.Infrastructure.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            

            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ILineItemRepository, LineItemRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
