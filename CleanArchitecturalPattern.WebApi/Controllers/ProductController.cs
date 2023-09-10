using CleanArchitecturalPattern.Application.Interfaces.Services;
using CleanArchitecturalPattern.Domain.Entities;
using CleanArchitecturalPattern.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecturalPattern.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductModel model)
        {
            try
            {
                //map model to entity 
                var product = new Product
                {
                    Id = model.Id,
                    ProductName = model.ProductName,
                    ProductDescription = model.ProductDescription,
                    ProductSKU = model.ProductSKU,
                    Price = model.Price,
                    Vendor = model.Vendor,
                };

                var createProduct = await _productService.AddProduct(product);

                return CreatedAtAction(nameof(AddProduct), new { Id = product.Id }, createProduct);
            }
            catch (Exception ex) 
            {
                throw ex;
            } 
        }

        [HttpGet]
        public async Task<IActionResult> GetProduct(Guid id)
        {
            try
            {
                var product = await _productService.GetProductById(id);

                return Ok(product);
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            try
            {
                var products = await _productService.GetAllProducts();

                return Ok(products);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
