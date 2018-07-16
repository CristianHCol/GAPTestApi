using System.Collections.Generic;
using GrowTestApi.Model;


namespace GrowTestApi.Services
{
    public interface IAgencyService
    {
        void InitializedMaster();
        List<Agency> GetAll();
        Agency GetById(long id);
        bool Create(Agency agency);
        bool Update(long id, Agency agency);
        bool Delete(long id);
    }
}
