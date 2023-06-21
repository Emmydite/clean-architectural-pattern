using CleanArchitecturalPattern.Application.Interfaces.Repositories;
using CleanArchitecturalPattern.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecturalPattern.Application.Services
{
    public class ProductService : IProductService
    {
        public readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {

        }
    }
}
