using BookStore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public interface ICategoryRepository 
    {
        Task<Category> FindCategory(Category addrequest);
        Task<List<Category>> FindAllCategory(List<Category> addrequest);
        Task<Category> AddCategory(Category addrequest);
        void AddListOfCategory(List<Category> addrequest);
        Task<List<Category>> UpdateCategory(List<Category> addrequest);
        Task<bool> DeleteCategory(int categoryid);
    }
}
