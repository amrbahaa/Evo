namespace Evo.Domain.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    
    public interface IRepository<T, K>
    {
        Task Create(T item);

        Task<IEnumerable<T>> GetList(object condition = null);

        Task<T> GetById(K id);

        Task<Boolean> Update(K id, T item);

        Task<Boolean> Delete(K id);

        Task<Boolean> Delete(object condition = null);
    }
}
