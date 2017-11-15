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

    public class AssessmentRepository : BaseRepository<Assessment, string>, IAssessmentRepository
    {
        public AssessmentRepository(IOptions<DbSettings> settings)
            : base(settings) { }

        public Task<IEnumerable<Assessment>> GetUserAssesments(string userId)
        {            
            var userAssessmentsFilter = Builders<Assessment>.Filter.Eq("UserId", userId);

            return GetList(userAssessmentsFilter);
        }
    }
}
