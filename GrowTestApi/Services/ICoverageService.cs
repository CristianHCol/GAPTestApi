using System.Collections.Generic;
using GrowTestApi.Model;


namespace GrowTestApi.Services
{
    public interface ICoverageService
    {
        void InitializedMaster();
        List<CoverageType> GetAll();
        CoverageType GetById(long id);
        bool Create(CoverageType coverage);
        bool Update(long id, CoverageType coverage);
        bool Delete(long id);
    }
}
