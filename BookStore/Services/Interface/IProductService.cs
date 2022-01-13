using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public  interface IProductService
    {
        Task<List<ProductDto>> GetProduct();
        Task<ProductDto> GetProductById(int productid);
        Task<List<ProductDto>> GetAllSubProduct();
        Task<ProductDto> AddProduct(ProductDto request);
        Task<ProductDto> UpdateProduct(ProductDto request);
        Task<ProductDto> DeleteProduct(int productid);
    }
}
