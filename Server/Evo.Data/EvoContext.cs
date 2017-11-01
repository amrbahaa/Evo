using System;
using System.Collections.Generic;
using System.Text;
using Evo.Data.Common;
using Evo.Domain.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Evo.Data
{
    public class EvoContext
    {
        private readonly IMongoDatabase _database = null;

        public EvoContext(IOptions<DbSettings> settings)
        {
            try
            {
                var client = new MongoClient(settings.Value.ConnectionString);
                _database = client.GetDatabase(settings.Value.Database);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IMongoCollection<Assessment> Assessments
        {
            get
            {
                return _database.GetCollection<Assessment>("Assessment");
            }
        }
    }
}
