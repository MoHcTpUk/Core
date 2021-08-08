using Core.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.DAL.Repository
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        public IEnumerable<TEntity> GetAll();
        public TEntity Get(int id);
        public Task<IEnumerable<TEntity>> FindAsync(Func<TEntity, bool> predicate);
        public Task<TEntity> CreateAsync(TEntity item);
        public Task<TEntity> UpdateAsync(TEntity item);
        public Task<bool> DeleteAsync(int id);
    }
}