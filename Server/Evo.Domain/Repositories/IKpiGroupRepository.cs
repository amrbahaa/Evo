using Evo.Domain.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Evo.Domain.Repositories
{
    public interface IKpiGroupRepository
    {
        Task<Boolean> AddKpiGroup(KpiGroup item);

        Task<KpiGroup> GetKpiGroup(string id);

        Task<UpdateResult> UpdateKpiGroup(string id, Kpi item);

        Task<UpdateResult> DeleteKpiGroup(string id);
    }
}
