using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Evo.Domain.Entities;
using MongoDB.Driver;

namespace Evo.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<Boolean> AddUser(User item);

        Task<User> GetUser(string id);

        Task<UpdateResult> UpdateUser(string id, User item);
    }
}
