using CleanArchitecturalPattern.Application.Interfaces.Services;
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

        public IActionResult AddProduct(Product product)
        {
            try
            {
                var createProduct = _productService.AddProduct()
            }
            catch (Exception ex) 
            {
                throw ex;
            } 
        }
    }
}
