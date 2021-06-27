using Core.Module.MongoDb.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Module.MongoDb.Services
{
    public interface IMongdoDbService<TEntity> where TEntity : IMongoDBEntity
    {
        Task<IEnumerable<TEntity>> SelectAsync(Func<TEntity, bool> predicate);
        Task<TEntity> CreateAsync(TEntity dto);
        Task<TEntity> UpdateAsync(TEntity dto);
        Task<bool> DeleteAsync(int id);
    }
}