using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShareT.Mongo
{
    /// <summary>
    /// 定义针对mongo的crud
    /// </summary>
    /// <typeparam name="TDocument"></typeparam>
    public interface IBaseMongoCollection<TDocument> where TDocument : class
    {
        IMongoCollection<TDocument> Collection { get; }

        IMongoQueryable<TDocument> Queryable { get; }

        void InsertOne(TDocument document);

        Task InsertOneAsync(TDocument document);

        void InsertMany(IEnumerable<TDocument> documents);

        Task InsertManyAsync(IEnumerable<TDocument> documents);

        IAsyncCursor<TDocument> Find(Expression<Func<TDocument, bool>> predicate,
            FindOptions<TDocument, TDocument> options = null, CancellationToken cancellationToken = default(CancellationToken));

        Task<IAsyncCursor<TDocument>> FindAsync(Expression<Func<TDocument, bool>> predicate,
            FindOptions<TDocument, TDocument> options = null, CancellationToken cancellationToken = default(CancellationToken));

        void ReplaceOne(Expression<Func<TDocument, bool>> predicate, TDocument document, UpdateOptions options = null, CancellationToken cancellationToken = default(CancellationToken));

        Task ReplaceOneAsync(Expression<Func<TDocument, bool>> predicate, TDocument document, UpdateOptions options = null, CancellationToken cancellationToken = default(CancellationToken));

        void DeleteOne(Expression<Func<TDocument, bool>> predicate, CancellationToken cancellationToken = default(CancellationToken));

        Task DeleteOneAsync(Expression<Func<TDocument, bool>> predicate, CancellationToken cancellationToken = default(CancellationToken));
    }
}
