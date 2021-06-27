using Core.Module.MongoDb.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Core.Module.MongoDb.Repository
{
    public interface IMongoDbRepository<TEntity> where TEntity : IMongoDBEntity
    {
        public IEnumerable<TEntity> GetAll();
        public TEntity Get(ObjectId id);
        public Task<IEnumerable<TEntity>> FindAsync(Func<TEntity, bool> predicate);
        public Task<TEntity> CreateAsync(TEntity item);
        public Task<TEntity> UpdateAsync(TEntity item);
        public Task<bool> DeleteAsync(ObjectId id);
    }
}