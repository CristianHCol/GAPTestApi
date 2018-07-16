using System.Collections.Generic;
using System.Threading.Tasks;
using GrowTestApi.Model;


namespace GrowTestApi.Services
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(long id);
        bool Create(Customer customer);
        bool Update(long id, Customer customer);
        bool Delete(long id);
    }
}
