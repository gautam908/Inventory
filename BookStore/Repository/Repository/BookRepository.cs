//using BookStore.Models;
//using BookStore.Repository;
//using MongoDB.Bson;
//using MongoDB.Driver;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace BookStore.Repository
//{
//    public partial class BookRepository : IBookRepository
//    {
//        private readonly IMongoCollection<Book> _collection;

//        public BookRepository(MongoCollectionSettings settings)
//        {
//            var database = new MongoClient(settings.ConnectionString).GetDatabase(settings.DatabaseName);
//            _collection = database.GetCollection<Book>(GetCollectionName(typeof(Book)));
//        }

//        private protected string GetCollectionName(Type documentType)
//        {
//            return ((MongoCollectionSettings)documentType.GetCustomAttributes(
//                    typeof(MongoCollectionBase),
//                    true)
//                .FirstOrDefault())?.CollectionName;
//        }

//        public virtual IQueryable<Book> AsQueryable()
//        {
//            return _collection.AsQueryable();
//        }

//        public virtual IEnumerable<Book> FilterBy(
//            Expression<Func<Book, bool>> filterExpression)
//        {
//            return _collection.Find(filterExpression).ToEnumerable();
//        }

//        public virtual IEnumerable<TProjected> FilterBy<TProjected>(
//            Expression<Func<Book, bool>> filterExpression,
//            Expression<Func<Book, TProjected>> projectionExpression)
//        {
//            return _collection.Find(filterExpression).Project(projectionExpression).ToEnumerable();
//        }

//        public virtual Book FindOne(Expression<Func<Book, bool>> filterExpression)
//        {
//            return _collection.Find(filterExpression).FirstOrDefault();
//        }

//        public virtual Task<Book> FindOneAsync(Expression<Func<Book, bool>> filterExpression)
//        {
//            return Task.Run(() => _collection.Find(filterExpression).FirstOrDefaultAsync());
//        }

//        public virtual Book FindById(string id)
//        {
//            var objectId = new ObjectId(id);
//            var filter = Builders<Book>.Filter.Eq(doc => doc.Id, objectId);
//            return _collection.Find(filter).SingleOrDefault();
//        }

//        public virtual Task<Book> FindByIdAsync(string id)
//        {
//            return Task.Run(() =>
//            {
//                var objectId = new ObjectId(id);
//                var filter = Builders<Book>.Filter.Eq(doc => doc.Id, objectId);
//                return _collection.Find(filter).SingleOrDefaultAsync();
//            });
//        }


//        public virtual void InsertOne(Book document)
//        {
//            _collection.InsertOne(document);
//        }

//        public virtual Task InsertOneAsync(Book document)
//        {
//            return Task.Run(() => _collection.InsertOneAsync(document));
//        }

//        public void InsertMany(ICollection<Book> documents)
//        {
//            _collection.InsertMany(documents);
//        }


//        public virtual async Task InsertManyAsync(ICollection<Book> documents)
//        {
//            await _collection.InsertManyAsync(documents);
//        }

//        public void ReplaceOne(Book document)
//        {
//            var filter = Builders<Book>.Filter.Eq(doc => doc.Id, document.Id);
//            _collection.FindOneAndReplace(filter, document);
//        }

//        public virtual async Task ReplaceOneAsync(Book document)
//        {
//            var filter = Builders<Book>.Filter.Eq(doc => doc.Id, document.Id);
//            await _collection.FindOneAndReplaceAsync(filter, document);
//        }

//        public void DeleteOne(Expression<Func<Book, bool>> filterExpression)
//        {
//            _collection.FindOneAndDelete(filterExpression);
//        }

//        public Task DeleteOneAsync(Expression<Func<Book, bool>> filterExpression)
//        {
//            return Task.Run(() => _collection.FindOneAndDeleteAsync(filterExpression));
//        }

//        public void DeleteById(string id)
//        {
//            var objectId = new ObjectId(id);
//            var filter = Builders<Book>.Filter.Eq(doc => doc.Id, objectId);
//            _collection.FindOneAndDelete(filter);
//        }

//        public Task DeleteByIdAsync(string id)
//        {
//            return Task.Run(() =>
//            {
//                var objectId = new ObjectId(id);
//                var filter = Builders<Book>.Filter.Eq(doc => doc.Id, objectId);
//                _collection.FindOneAndDeleteAsync(filter);
//            });
//        }

//        public void DeleteMany(Expression<Func<Book, bool>> filterExpression)
//        {
//            _collection.DeleteMany(filterExpression);
//        }

//        public Task DeleteManyAsync(Expression<Func<Book, bool>> filterExpression)
//        {
//            return Task.Run(() => _collection.DeleteManyAsync(filterExpression));
//        }
//    }
//}