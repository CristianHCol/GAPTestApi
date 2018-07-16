using System.Collections.Generic;
using GrowTestApi.Model;


namespace GrowTestApi.Services
{
    public interface IPolicyService
    {
        List<Policy> GetAll();
        Policy GetById(long id);
        bool Create(Policy policy);
        bool Update(long id, Policy policy);
        bool Delete(long id);
    }
}
