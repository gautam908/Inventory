using BookStore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public interface IProductRepository
    {
        Task<Product> FindProduct(Product addrequest);
        Task<List<Product>> FindAllProduct(List<Product> addrequest);
        Task<Product> AddProduct(Product addrequest);
        void AddListOfProduct(List<Product> addrequest);
        Task<List<Product>> UpdateProduct(List<Product> addrequest);
        Task<bool> DeleteProduct(int productid);
    }
}
