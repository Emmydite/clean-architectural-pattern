using CleanArchitecturalPattern.Domain.Entities;

namespace CleanArchitecturalPattern.Application.Interfaces.Services
{
    public interface IProductService
    {
        Task<int> AddProduct(Product product);
        Task<bool> UpdateProduct(Product product);
        void DeleteProduct(Guid id);
        Task<Product> GetProductById(Guid id);
        Task<List<Product>> GetAllProducts();
    }
}
