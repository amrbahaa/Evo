namespace Evo.Data.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Options;
    using MongoDB.Bson;
    using MongoDB.Driver;
    using Evo.Data.Common;
    using Evo.Domain;
    using Evo.Domain.Entities;
    using Evo.Domain.Repositories;

    public class UserRepository : BaseRepository<User, string>, IUserRepository
    {
        public UserRepository(IOptions<DbSettings> settings)
            : base(settings) { }
    }
}
