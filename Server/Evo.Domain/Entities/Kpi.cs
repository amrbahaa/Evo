using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Evo.Domain.Entities
{
    public class Kpi: BaseEntity
    {
        [BsonId]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public string KpiGroupId { get; set; }
    }
}
