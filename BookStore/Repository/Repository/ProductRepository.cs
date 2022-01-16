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

        public void AddListOfProduct(List<Product> addrequest)
        {
            try
            {
                _productRepository.InsertManyAsync(addrequest);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<Product> AddProduct(Product addrequest)
        {
            try
            {
               await _productRepository.InsertOneAsync(addrequest);
            }
            catch (Exception ex)
            {
                throw;   
            }
            return(addrequest);
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

        public async Task<List<Product>> FindAllProduct(List<Product> addrequest)
        {
            try
            {
               await _productRepository.InsertManyAsync(addrequest);
            }
            catch (Exception ex)
            {
                throw;
            }
            return(addrequest);
        }

        public async Task<Product> FindProduct(Product addrequest)
        {
            try
            {
                await _productRepository.InsertOneAsync(addrequest);
            }
            catch (Exception ex)
            {

                throw;
            }
            return(addrequest);
        }

        public async Task<List<Product>> UpdateProduct(List<Product> addrequest)
        {
            try
            {
                await _productRepository.InsertManyAsync(addrequest);
            }
            catch (Exception ex)
            {

                throw;
            }
            return(addrequest);
        }
    }
}
