using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using ShareT.Mongo.Attributes;

namespace ShareT.Mongo
{
    public class BaseMongoCollection<TDocument> : IBaseMongoCollection<TDocument> where TDocument : class
    {

        private IMongoCollection<TDocument> _collection;

        public IMongoCollection<TDocument> Collection => _collection;

        public IMongoQueryable<TDocument> Queryable => _collection.AsQueryable();


        public BaseMongoCollection(MongoContext context, string collectionName = null)
        {
            _collection = context.Database.GetCollection<TDocument>(collectionName ?? GetMongoCollectionName());
        }

        private string GetMongoCollectionName()
        {
            var documentType = typeof(TDocument);
            var mongoCollection = documentType.GetCustomAttribute<MongoCollectionAttribute>();
            var collectionName = mongoCollection != null ? mongoCollection.Name : documentType.Name;

            return collectionName;
        }

        #region r
        public IAsyncCursor<TDocument> Find(Expression<Func<TDocument, bool>> predicate, FindOptions<TDocument, TDocument> options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return _collection.FindSync(predicate, options, cancellationToken);
        }

        public async Task<IAsyncCursor<TDocument>> FindAsync(Expression<Func<TDocument, bool>> predicate, FindOptions<TDocument, TDocument> options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await _collection.FindAsync(predicate, options, cancellationToken);
        } 
        #endregion


        #region c
        public void InsertOne(TDocument document)
        {
            _collection.InsertOne(document);
        }

        public async Task InsertOneAsync(TDocument document)
        {
            await _collection.InsertOneAsync(document);
        }

        public void InsertMany(IEnumerable<TDocument> documents)
        {
            _collection.InsertMany(documents);
        }

        public async Task InsertManyAsync(IEnumerable<TDocument> documents)
        {
            await _collection.InsertManyAsync(documents);
        }
        #endregion



        #region u
        public void ReplaceOne(Expression<Func<TDocument, bool>> predicate, TDocument document, UpdateOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            _collection.ReplaceOne(predicate, document, options, cancellationToken);
        }

        public async Task ReplaceOneAsync(Expression<Func<TDocument, bool>> predicate, TDocument document, UpdateOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            await _collection.ReplaceOneAsync(predicate, document, options, cancellationToken);
        } 
        #endregion


        #region d
        public void DeleteOne(Expression<Func<TDocument, bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
        {
            _collection.DeleteOne(predicate, cancellationToken);
        }

        public async Task DeleteOneAsync(Expression<Func<TDocument, bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
        {
            await _collection.DeleteOneAsync(predicate, cancellationToken);
        }
        #endregion
    }
}
