using Core.Module.MongoDb.Entities;
using Core.Module.MongoDb.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Module.MongoDb.Services
{
    public abstract class MongoDbServiceAbstract<TEntity> : IMongdoDbService<TEntity> where TEntity : IMongoDBEntity
    {
        private readonly IMongoDbRepository<TEntity> _repository;

        protected MongoDbServiceAbstract(IMongoDbRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            var newEntity = await _repository.CreateAsync(entity);
            return newEntity;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<TEntity>> SelectAsync(Func<TEntity, bool> predicate)
        {
            var entities = await _repository.FindAsync(predicate);
            return entities;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var updatedEntity = await _repository.UpdateAsync(entity);

            return updatedEntity;
        }
    }
}