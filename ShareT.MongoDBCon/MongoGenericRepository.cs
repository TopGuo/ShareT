using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShareT.MongoDBCon
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TDocument"></typeparam>
    public class MongoGenericRepository<TDocument> : IGenericRepository<TDocument>
    {
        private IMongoCollection<TDocument> _collection;

        public IMongoCollection<TDocument> Collection => _collection;

        public IMongoQueryable<TDocument> Queryable => _collection.AsQueryable();

        public MongoGenericRepository(IMongoDatabase database, string collectionName)
        {
            _collection = database.GetCollection<TDocument>(collectionName);
        }

        public async Task InsertOneAsync(TDocument document)
        {
            await _collection.InsertOneAsync(document);
        }

        public async Task InsertManyAsync(IEnumerable<TDocument> documents)
        {
            await _collection.InsertManyAsync(documents);
        }

        public async Task<IAsyncCursor<TDocument>> FindAsync(Expression<Func<TDocument, bool>> predicate,
            FindOptions<TDocument, TDocument> options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await _collection.FindAsync(predicate, options, cancellationToken);
        }

        public void InsertOne(TDocument document)
        {
            _collection.InsertOne(document);
        }

        //public IAsyncCursor<TDocument> Find(Expression<Func<TDocument, bool>> predicate, FindOptions<TDocument, TDocument> options = null, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    return _collection.Find(predicate, options, cancellationToken);
        //}
    }


    public interface IGenericRepository<TDocument>
    {
        IMongoCollection<TDocument> Collection { get; }

        IMongoQueryable<TDocument> Queryable { get; }

        void InsertOne(TDocument document);

        Task InsertManyAsync(IEnumerable<TDocument> documents);

        Task<IAsyncCursor<TDocument>> FindAsync(Expression<Func<TDocument, bool>> predicate,
            FindOptions<TDocument, TDocument> options = null, CancellationToken cancellationToken = default(CancellationToken));

        
    }


}
