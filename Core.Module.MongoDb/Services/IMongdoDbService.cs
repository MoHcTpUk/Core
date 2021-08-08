using Core.Module.MongoDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Core.Module.MongoDb.Services
{
    public interface IMongdoDbService<TEntity> where TEntity : IMongoDBEntity
    {
        Task<List<TEntity>> SelectAsync(List<Expression<Func<TEntity, bool>>> predicateList);
        Task<TEntity> CreateAsync(TEntity dto);
        Task<TEntity> UpdateAsync(TEntity dto);
        Task<bool> DeleteAsync(ObjectId id);
    }
}