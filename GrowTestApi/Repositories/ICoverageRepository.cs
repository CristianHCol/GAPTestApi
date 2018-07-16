using System.Collections.Generic;
using GrowTestApi.Model;

namespace GrowTestApi.Repositories
{
    public interface ICoverageRepository
    {
        void InitializedMaster();
        List<CoverageType> GetAll();
        CoverageType GetById(long id);
        bool Create(CoverageType coverageTypes);
        bool Update(long id, CoverageType coverageTypes);
        bool Delete(long id);
    }
}