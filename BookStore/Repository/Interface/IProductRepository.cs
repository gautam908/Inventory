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
        Task<Product> FindProduct(Expression<Func<Entity.Product, bool>> predicate = null);
        Task<List<Entity.Product>> FindAllProduct(Expression<Func<Entity.Product, bool>> predicate = null);
        Task<Product> AddProduct(Product addrequest);
        Task<bool> UpdateProduct(BookStore.Entity.Product addrequest);
        Task<bool> DeleteProduct(int productid);
        void AddListOfProduct(List<BookStore.Entity.Product> addrequest);
    }
}
