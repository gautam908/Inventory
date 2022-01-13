using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using MongoDB.Bson;

namespace BookStore.Services.Interface
{
    public interface IBookService
    {
        Task<List<Book>> Get();
        Task<string> AddBook(Book addrequest);
        Task<string> UpdateBook(Book updaterequest);
        Task<string> DeleteBook(ObjectId id);
        Task<Book> GetById(ObjectId id);
    }
}
