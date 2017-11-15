namespace Evo.Data.Repositories
{

    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Text;
    using Microsoft.Extensions.Options;
    using MongoDB.Driver;
    using MongoDB.Bson;
    using Evo.Data.Common;
    using Evo.Domain.Repositories;

    public abstract class BaseRepository<T, K> : IMongoDbRepository<T, K>
        where T : class
        where K : IEquatable<K>, IComparable<K>, IConvertible
    {
        protected readonly EvoContext<T> _context;

        public BaseRepository(IOptions<DbSettings> settings)
        {
            _context = new EvoContext<T>(settings, typeof(K).Name);
        }

        public async Task Create(T item)
        {
            try
            {
                await _context.Collection.InsertOneAsync(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Boolean> Delete(K id)
        {
            try
            {
                var filter = Builders<T>.Filter.Eq("Id", id);
                var result = await _context.Collection.DeleteOneAsync(filter);
                return result.IsAcknowledged;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> GetById(K id)
        {
            var filter = Builders<T>.Filter.Eq("Id", id);
            return await _context.Collection.Find(filter).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> GetList(object condition = null)
        {
            try
            {
                if (condition == null)
                {
                    condition = FilterDefinition<T>.Empty;
                }

                return await this._context.Collection.Find(condition as FilterDefinition<T>).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Boolean> Update(K id, T item)
        {
            try
            {
                var filter = Builders<T>.Filter.Eq("Id", id);
                var options = new UpdateOptions() { IsUpsert = true };

                var result = await _context.Collection.ReplaceOneAsync(filter, item, options);
                return result.IsAcknowledged;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Boolean> Delete(object condition = null)
        {
            try
            {
                var result = await _context.Collection.DeleteManyAsync(condition as FilterDefinition<T>);
                return result.IsAcknowledged;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
