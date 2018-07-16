using System.Collections.Generic;
using System.Threading.Tasks;
using GrowTestApi.Model;

namespace GrowTestApi.Repositories
{
    public interface IPolicyRepository
    {
        List<Policy> GetAll();
        Policy GetById(long id);
        bool Create(Policy policy);
        bool Update(long id, Policy policy);
        bool Delete(long id);
    }
}