namespace Evo.Domain.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /* 
     * TODO MOGNO prefix due to using Mongo Lib in interface like 
     * "MongoDB.Driver.FilterDefinition"
     * "MongoDB.Driver.ReplaceOneResult"
     * "MongoDB.Driver.DeleteResult"'     
     * 
     * Otherwise, return Boolean or custom type like DbResult { Status: bool, Message: string, Value: Object }
    */

    public interface IMongoDbRepository<T, K>
    {
        Task Create(T item);

        Task<IEnumerable<T>> GetList(object condition = null);

        Task<T> GetById(K id);

        Task<Boolean> Update(K id, T item);

        Task<Boolean> Delete(K id);

        Task<Boolean> Delete(object condition = null);
    }
}
