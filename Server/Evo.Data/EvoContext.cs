using System;
using System.Collections.Generic;
using System.Text;
using Evo.Data.Common;
using Evo.Domain.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Evo.Data
{
    public class EvoContext<T> where T : class
    {
        private readonly IMongoDatabase _database = null;
        private string _collectionName;
        private IMongoCollection<T> _collection;

        public IMongoCollection<T> Collection { get { return _collection; } }

        public EvoContext(IOptions<DbSettings> settings, string tableName)
        {
            try
            {
                var client = new MongoClient(settings.Value.ConnectionString);

                _database = client.GetDatabase(settings.Value.Database);
                _collectionName = tableName;
                _collection = _database.GetCollection<T>(tableName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
