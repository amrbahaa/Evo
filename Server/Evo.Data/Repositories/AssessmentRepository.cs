using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Evo.Data.Common;
using Evo.Domain;
using Evo.Domain.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Evo.Data.Repositories
{
    public class AssessmentRepository : IAssessmentRepository
    {
        private readonly EvoContext _context;

        public AssessmentRepository(IOptions<DbSettings> settings)
        {
            _context = new EvoContext(settings);
        }
        public async Task<IEnumerable<Assessment>> GetAllAssesments()
        {
            return await _context.Assessments.Find(_ => true).ToListAsync();
        }

        public async Task<Assessment> GetAssessment(string id)
        {
            var filter = Builders<Assessment>.Filter.Eq("Id", id);
            return await _context.Assessments
                .Find(filter)
                .FirstOrDefaultAsync();
        }

        public async Task AddAssessment(Assessment item)
        {
            await _context.Assessments.InsertOneAsync(item);
        }

        public async Task<DeleteResult> RemoveAssessment(string id)
        {
            return await _context.Assessments.DeleteOneAsync(
                Builders<Assessment>.Filter.Eq("Id", id));
        }

        public async Task<UpdateResult> UpdateAssessment(string id, string body)
        {
            var filter = Builders<Assessment>.Filter.Eq(s => s.Id, id);
            var update = Builders<Assessment>.Update
                .Set(s => s.Body, body)
                .CurrentDate(s => s.UpdatedOn);
            return await _context.Assessments.UpdateOneAsync(filter, update);
        }

        public async Task<ReplaceOneResult> UpdateAssessmentDocument(string id, Assessment item)
        {
            return await _context.Assessments
                .ReplaceOneAsync(n => n.Id.Equals(id)
                    , item
                    , new UpdateOptions { IsUpsert = true });
        }

        public async Task<DeleteResult> RemoveAllAssessments()
        {
            return await _context.Assessments.DeleteManyAsync(new BsonDocument());
        }
    }
}
