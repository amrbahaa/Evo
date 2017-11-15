namespace Evo.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Evo.Domain.Entities;

    public interface IAssessmentRepository
    {
        Task<IEnumerable<Assessment>> GetUserAssesments(string userId);
    }
}
