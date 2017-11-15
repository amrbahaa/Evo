using Evo.Domain.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Evo.Domain.Repositories
{
    public interface IKpiRepository
    {
        Task<Boolean> AddKpi(Kpi item);

        Task<Kpi> GetKpi(string id);

        Task<UpdateResult> UpdateKpi(string id, Kpi item);

        Task<UpdateResult> DeleteKpi(string id);
    }
}
