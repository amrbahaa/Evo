using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Evo.Domain.Entities;
using MongoDB.Driver;

namespace Evo.Domain
{
    public interface IAssessmentRepository
    {
        Task<IEnumerable<Assessment>> GetAllAssesments();
        Task<Assessment> GetAssessment(string id);
        Task AddAssessment(Assessment item);
        Task<DeleteResult> RemoveAssessment(string id);
        Task<UpdateResult> UpdateAssessment(string id, string body);

        // demo interface - full document update
        Task<ReplaceOneResult> UpdateAssessmentDocument(string id, Assessment item);

        // should be used with high cautious, only in relation with demo setup
        Task<DeleteResult> RemoveAllAssessments();
    }
}
