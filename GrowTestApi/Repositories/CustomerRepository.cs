using System.Collections.Generic;
using System.Linq;
using GrowTestApi.Model;

namespace GrowTestApi.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomersContext _context;

        public CustomerRepository(CustomersContext context)
        {
            _context = context;
        }

        public bool Create(Customer customer)
        {
            _context.CustomerItems.Add(customer);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(long id)
        {
            var customer = _context.CustomerItems.Find(id);
            if (customer == null)
            {
                return false;
            }

            _context.CustomerItems.Remove(customer);
            _context.SaveChanges();
            return true;
        }

        public List<Customer> GetAll()
        {
            return _context.CustomerItems.ToList();
        }

        public Customer GetById(long id)
        {
            return _context.CustomerItems.Find(id);
        }

        public bool Update(long id, Customer customer)
        {
            var oldCustomer = _context.CustomerItems.Find(id);
            if (oldCustomer == null)
            {
                return false;
            }
            oldCustomer = customer;
            _context.CustomerItems.Update(oldCustomer);
            _context.SaveChanges();
            return true;
        }
    }
}
