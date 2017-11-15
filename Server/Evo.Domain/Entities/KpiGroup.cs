using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Evo.Domain.Entities
{
    public class KpiGroup : BaseEntity
    {
        [BsonId]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description{ get; set; }

        public bool IsActive{ get; set; }                
    }
}
