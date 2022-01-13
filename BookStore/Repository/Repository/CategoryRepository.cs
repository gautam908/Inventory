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
    public class CategoryRepository : ICategoryRepository
    {
        #region Fields
        private readonly IMongoCollection<Category> _categoryRepository;
        #endregion

        #region Ctor



        /// <summary>
        /// Ctor
        /// </summary>
        public CategoryRepository(IBookStoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _categoryRepository = database.GetCollection<Category>("Category");
        }
        #endregion



        public void AddCategory(Category addrequest)
        {
            try
            {
                _categoryRepository.InsertOneAsync(addrequest);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void AddListOfCategory(List<Category> addrequest)
        {
            try
            {
                _categoryRepository.InsertManyAsync(addrequest);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<bool> DeleteCategory(int categoryid)
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

        public  void FindAllCategory(Expression<Func<Category, bool>> predicate = null)
        {
            try
            {
                 _categoryRepository.f(predicate);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void FindCategory(Expression<Func<Category, bool>> predicate = null)
        {
            try
            {
                 _categoryRepository.FindAsync(predicate);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void UpdateCategory(Expression<Func<Category, bool>> predicate = null)
        {
            try
            {
               _categoryRepository.UpdateOneAsync(predicate);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
