using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.BLL.Services
{
    public interface IService<out TEntity, TDTO> where TDTO : class
    {
        Task<IEnumerable<TDTO>> SelectAsync(Func<TEntity, bool> predicate);
        Task<TDTO> CreateAsync(TDTO dto);
        Task<TDTO> UpdateAsync(TDTO dto);
        Task<bool> DeleteAsync(int id);
    }
}