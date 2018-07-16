using System.Collections.Generic;
using System.Linq;
using GrowTestApi.Model;

namespace GrowTestApi.Repositories
{
    public class AgencyRepository : IAgencyRepository
    {
        private readonly AgencyContext _context;

        public AgencyRepository(AgencyContext context)
        {
            _context = context;
        }

        public void InitializedMaster()
        {
            if (_context.AgencyItems.Count() == 0)
            {
                _context.AgencyItems.Add(new Agency { Name = "Agency1", Description = "Agency1 Description", Address = "Calle 1 # 11 - 44", TelNumber = "4111111" });
                _context.AgencyItems.Add(new Agency { Name = "Agency2", Description = "Agency2 Description", Address = "Calle 2 # 11 - 44", TelNumber = "4211111" });
                _context.AgencyItems.Add(new Agency { Name = "Agency3", Description = "Agency3 Description", Address = "Calle 3 # 11 - 44", TelNumber = "4311111" });
                _context.AgencyItems.Add(new Agency { Name = "Agency4", Description = "Agency4 Description", Address = "Calle 4 # 11 - 44", TelNumber = "4411111" });
                _context.SaveChanges();
            }
        }

        public bool Create(Agency agency)
        {
            _context.AgencyItems.Add(agency);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(long id)
        {
            var agency = _context.AgencyItems.Find(id);
            if (agency == null)
            {
                return false;
            }

            _context.AgencyItems.Remove(agency);
            _context.SaveChanges();
            return true;
        }

        public List<Agency> GetAll()
        {
            return _context.AgencyItems.ToList();
        }

        public Agency GetById(long id)
        {
            return _context.AgencyItems.Find(id);
        }

        public bool Update(long id, Agency agency)
        {
            var oldAgency = _context.AgencyItems.Find(id);
            if (oldAgency == null)
            {
                return false;
            }
            oldAgency = agency;
            _context.AgencyItems.Update(oldAgency);
            _context.SaveChanges();
            return true;
        }
    }
}
