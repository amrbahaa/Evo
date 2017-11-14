using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Evo.Domain.Entities
{
    public class User
    {
        [BsonId]
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public DateTime UpdatedOn { get; set; }
    }
}
