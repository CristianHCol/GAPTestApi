using System.Collections.Generic;
using GrowTestApi.Model;


namespace GrowTestApi.Services
{
    public interface IRiskService
    {
        void InitializedMaster();
        List<Risk> GetAll();
        Risk GetById(long id);
        bool Create(Risk risk);
        bool Update(long id, Risk risk);
        bool Delete(long id);
    }
}
