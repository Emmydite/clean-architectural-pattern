using CleanArchitecturalPattern.Application.Interfaces.Repositories;
using CleanArchitecturalPattern.Application.Interfaces.Services;
using CleanArchitecturalPattern.Domain.Entities;
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
            _productRepository = productRepository;
        }

        public async Task<int> AddProduct(Product product)
        {
            try
            {
                await _productRepository.AddAsync(product);
                var result = await _productRepository.SaveChanges();

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            try
            {
                _productRepository.Update(product);
                var result = await _productRepository.SaveChanges();

                return result == 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteProduct(Guid id)
        {
            try
            {
                var product = _productRepository.GetByIdAsync(id).GetAwaiter().GetResult();
                if (product != null)
                {
                    _productRepository.Delete(product);
                    _productRepository.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Product> GetProductById(Guid id)
        {   
            try
            {
                var product = await _productRepository.GetByIdAsync(id);

                return product;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<Product> GetAllProducts()
        {
            try
            {
                var products = _productRepository.GetAllAsync()
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
