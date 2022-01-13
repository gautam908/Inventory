using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public interface ICategoryService
    {
        Task<List<CategoryDto>> GetCategory();
        Task<CategoryDto> GetCategoryById(int categoryid);
        Task<List<CategoryDto>> GetAllSubCategory();
        Task<CategoryDto> AddCategory(CategoryDto request);
        Task<CategoryDto> UpdateCategory(CategoryDto request);
        Task<CategoryDto> DeleteCategory(int categoryid);
    }
}
