using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;

namespace Evo.Domain.Entities
{
    public class Assessment
    {
        [BsonId]
        public string Id { get; set; }
        public string Body { get; set; } = string.Empty;
        public DateTime UpdatedOn { get; set; } = DateTime.Now;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int UserId { get; set; } = 0;
    }
}
