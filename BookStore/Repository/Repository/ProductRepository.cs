using BookStore.Entity;
using BookStore.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class ProductRepository : IProductRepository
    {
        #region Fields
        private readonly IMongoCollection<Product> _productRepository;
        #endregion

        #region Ctor



        /// <summary>
        /// Ctor
        /// </summary>
        public ProductRepository(IBookStoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _productRepository = database.GetCollection<Product>("Product");
        }
        #endregion
        public void AddListOfProduct(Product addrequest)
        {
            try
            {
                _productRepository.InsertOneAsync(addrequest);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void AddProduct(Product addrequest)
        {
            try
            {
                 _productRepository.InsertOne(addrequest);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> DeleteProduct(int productid)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<Product>> FindAllProduct(Expression<Func<Product, bool>> predicate = null)
        {
            try
            {
                return await _productRepository.InsertAsync(predicate);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Product> FindProduct(Expression<Func<Product, bool>> predicate = null)
        {
            try
            {
                return await _productRepository.Find(predicate);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool UpdateProduct(Product addrequest)
        {
            try
            {
                _productRepository.UpdateOneAsync(addrequest);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
