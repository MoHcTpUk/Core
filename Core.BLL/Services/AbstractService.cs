using AutoMapper;
using Core.DAL.Entities;
using Core.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.BLL.Services
{
    public abstract class AbstractService<TEntity, TDTO> : IService<TEntity, TDTO> where TEntity : AbstractEntity where TDTO : class
    {
        private readonly IMapper _mapper;
        private readonly IRepository<TEntity> _repository;

        protected AbstractService(IRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<TDTO> CreateAsync(TDTO dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            entity = await _repository.CreateAsync(entity);
            var createdEntityDto = _mapper.Map<TDTO>(entity);

            return createdEntityDto;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<TDTO>> SelectAsync(Func<TEntity, bool> predicate)
        {
            var entities = await _repository.FindAsync(predicate);
            var entitiesDto = _mapper.Map<IEnumerable<TDTO>>(entities);

            return entitiesDto;
        }

        public async Task<TDTO> UpdateAsync(TDTO dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            entity = await _repository.UpdateAsync(entity);
            var updatedEntityDto = _mapper.Map<TDTO>(entity);

            return updatedEntityDto;
        }
    }
}