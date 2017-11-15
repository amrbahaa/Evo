namespace Evo.Domain.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Evo.Domain.Entities;

    public interface IAssessmentRepository : IRepository<Assessment, string>
    {
        Task<IEnumerable<Assessment>> GetUserAssesments(string userId);
    }
}
