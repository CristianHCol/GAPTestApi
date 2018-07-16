using System.Collections.Generic;
using GrowTestApi.Model;

namespace GrowTestApi.Repositories
{
    public interface IAgencyRepository
    {
        void InitializedMaster();
        List<Agency> GetAll();
        Agency GetById(long id);
        bool Create(Agency policy);
        bool Update(long id, Agency agency);
        bool Delete(long id);
    }
}