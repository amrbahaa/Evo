using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Evo.Data.Common;
using Evo.Domain;
using Evo.Domain.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using Evo.Domain.Repositories;

namespace Evo.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly EvoContext _context;

        public UserRepository(IOptions<DbSettings> settings)
        {
            _context = new EvoContext(settings);
        }

        public async Task<Boolean> AddUser(User item)
        {
            await _context.Users.InsertOneAsync(item);

            return true;
        }

        public async Task<User> GetUser(string id)
        {
            var filter = Builders<User>.Filter.Eq("Id", id);
            return await _context.Users
                .Find(filter)
                .FirstOrDefaultAsync();
        }

        public async Task<UpdateResult> UpdateUser(string id, User item)
        {
            var filter = Builders<User>.Filter.Eq(s => s.Id, id);
            var update = Builders<User>.Update
                .Set(s => s.FirstName, item.FirstName)
                .Set(s => s.LastName, item.LastName)
                .Set(s => s.Email, item.Email)
                .CurrentDate(s => s.UpdatedOn);
            return await _context.Users.UpdateOneAsync(filter, update);
        }
    }
}
