﻿using CleanArchitecturalPattern.Application.Interfaces.Services;
using CleanArchitecturalPattern.Domain.Entities;
using CleanArchitecturalPattern.WebApi.Models;
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
                var product = new Product
                {
                    ProductName = model.ProductName,
                    ProductDescription = model.ProductDescription,
                    ProductSKU = model.ProductSKU,
                    Price = model.Price,
                    Vendor = model.Vendor,
                };

                var createProduct = await _productService.AddProduct(product);

                return CreatedAtAction(nameof(AddProduct), new { Id = createProduct }, createProduct);
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

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(ProductModel model)
        {
            try
            {
                var success = false;
                var product = await _productService.GetProductById(model.Id);

                if (product != null)
                {
                    product.ProductName = model.ProductName;
                    product.ProductDescription = model.ProductDescription;
                    product.ProductSKU = model.ProductSKU;
                    product.Price = model.Price;

                    success = await _productService.UpdateProduct(product);
                }

                return Ok(success);
            }
            catch (Exception ex) 
            {
                throw ex;
            } 
        }

        [HttpDelete]
        public IActionResult DeleteProduct(Guid id)
        {
            try
            {
                _productService.DeleteProduct(id);

                return Ok();
            }
            catch (Exception ex) 
            {
                throw ex;
            } 
        }
    }
}
