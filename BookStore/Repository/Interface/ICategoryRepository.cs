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
        void FindCategory(Expression<Func<Category, bool>> predicate = null);
        void FindAllCategory(Expression<Func<Category, bool>> predicate = null);
        void AddCategory(Category addrequest);
        void UpdateCategory(Category addrequest);
        Task<bool> DeleteCategory(int categoryid);
        void AddListOfCategory(List<Category> addrequest);
    }
}
