using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrowTestApi.Model;

namespace GrowTestApi.Repositories
{
    public class PolicyRepository : IPolicyRepository
    {
        private readonly PolicyContext _context;

        public PolicyRepository(PolicyContext context)
        {
            _context = context;
        }

        public bool Create(Policy policy)
        {
            _context.PolicyItems.Add(policy);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(long id)
        {
            var policy = _context.PolicyItems.Find(id);
            if (policy == null)
            {
                return false;
            }

            _context.PolicyItems.Remove(policy);
            _context.SaveChanges();
            return true;
        }

        public List<Policy> GetAll()
        {
            return _context.PolicyItems.ToList();
        }

        public Policy GetById(long id)
        {
            return _context.PolicyItems.Find(id);
        }

        public bool Update(long id, Policy policy)
        {
            var oldPolicy = _context.PolicyItems.Find(id);
            if (oldPolicy == null)
            {
                return false;
            }
            _context.PolicyItems.Update(policy);
            _context.SaveChanges();
            return true;
        }
    }
}
