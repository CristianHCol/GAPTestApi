using System.Collections.Generic;
using System.Threading.Tasks;
using GrowTestApi.Model;

namespace GrowTestApi.Repositories
{
    public interface IRiskRepository
    {
        void InitializedMaster();
        List<Risk> GetAll();
        Risk GetById(long id);
        bool Create(Risk risk);
        bool Update(long id, Risk risk);
        bool Delete(long id);
    }
}