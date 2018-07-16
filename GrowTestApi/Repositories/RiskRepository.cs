using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrowTestApi.Model;

namespace GrowTestApi.Repositories
{
    public class RiskRepository : IRiskRepository
    {
        private readonly RiskContext _context;

        public RiskRepository(RiskContext context)
        {
            _context = context;
        }

        public void InitializedMaster(){
            if (_context.RiskItems.Count() == 0)
            {
                _context.RiskItems.Add(new Risk { Description = "Bajo" });
                _context.RiskItems.Add(new Risk { Description = "Medio" });
                _context.RiskItems.Add(new Risk { Description = "Medio-Alto" });
                _context.RiskItems.Add(new Risk { Description = "Alto" });
                _context.SaveChanges();
            }
        }

        public bool Create(Risk risk)
        {
            _context.RiskItems.Add(risk);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(long id)
        {
            var risk = _context.RiskItems.Find(id);
            if (risk == null)
            {
                return false;
            }

            _context.RiskItems.Remove(risk);
            _context.SaveChanges();
            return true;
        }

        public List<Risk> GetAll()
        {
            return _context.RiskItems.ToList();
        }

        public Risk GetById(long id)
        {
            return _context.RiskItems.Find(id);
        }

        public bool Update(long id, Risk risk)
        {
            var oldRisk = _context.RiskItems.Find(id);
            if (oldRisk == null)
            {
                return false;
            }
            oldRisk = risk;
            _context.RiskItems.Update(oldRisk);
            _context.SaveChanges();
            return true;
        }
    }
}
