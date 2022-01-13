using BookStore.Entity;
using BookStore.Models;
using BookStore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class ProductController : Controller
    {
        #region Fields
        private readonly IProductService _productService;

        #endregion
        #region ctor
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        #endregion

        [HttpGet("GetProduct")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
        public async Task<IActionResult> GetProduct()
        {
            return Ok(await _productService.GetProduct());
        }

        [HttpGet("GetProductById")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
        public async Task<IActionResult> GetProductById(int productid)
        {
            return Ok(await _productService.GetProductById(productid));
        }

        [HttpPost("AddProduct")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
        public async Task<IActionResult> AddProduct(ProductDto addrequest)
        {
            return Ok(await _productService.AddProduct(addrequest));
        }

        [HttpPatch("UpdateBook")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
        public async Task<IActionResult> UpdateBook(ProductDto request)
        {
            return Ok(await _productService.UpdateProduct(request));
        }

        [HttpDelete("DeleteProduct")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
        public async Task<IActionResult> DeleteProduct(int  productid)
        {
            return Ok(await _productService.DeleteProduct(productid));
        }
    }
}
