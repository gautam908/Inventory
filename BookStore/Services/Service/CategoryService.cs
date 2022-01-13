using BookStore.Models;
using BookStore.Repository;
using BookStore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public class CategoryService : ICategoryService
    {
        #region Fields
        private readonly ICategoryRepository _categoryRepository;

        #endregion

       #region Ctor
       public CategoryService(ICategoryRepository categoryRepository)
       {
            _categoryRepository = categoryRepository;
       
       }
       #endregion

  
        public Task<CategoryDto> AddCategory(CategoryDto request)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> DeleteCategory(int categoryid)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryDto>> GetAllSubCategory()
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryDto>> GetCategory()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> GetCategoryById(int categoryid)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> UpdateCategory(CategoryDto request)
        {
            throw new NotImplementedException();
        }
    }
}
