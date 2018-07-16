using System.Collections.Generic;
using System.Linq;
using GrowTestApi.Model;

namespace GrowTestApi.Repositories
{
    public class CoverageRepository : ICoverageRepository
    {
        private readonly CoverageTypesContext _context;

        public CoverageRepository(CoverageTypesContext context)
        {
            _context = context;
        }

        public void InitializedMaster()
        {
            if (_context.CoverageItems.Count() == 0)
            {
                _context.CoverageItems.Add(new CoverageType { Description = "Terremoto", Percentage = 60 });
                _context.CoverageItems.Add(new CoverageType { Description = "Incendio", Percentage = 80 });
                _context.CoverageItems.Add(new CoverageType { Description = "Robo", Percentage = 90 });
                _context.CoverageItems.Add(new CoverageType { Description = "Pérdida", Percentage = 95 });
                _context.SaveChanges();
            }
        }

        public bool Create(CoverageType coverage)
        {
            _context.CoverageItems.Add(coverage);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(long id)
        {
            var coverage = _context.CoverageItems.Find(id);
            if (coverage == null)
            {
                return false;
            }

            _context.CoverageItems.Remove(coverage);
            _context.SaveChanges();
            return true;
        }

        public List<CoverageType> GetAll()
        {
            return _context.CoverageItems.ToList();
        }

        public CoverageType GetById(long id)
        {
            return _context.CoverageItems.Find(id);
        }

        public bool Update(long id, CoverageType coverage)
        {
            var oldCoverage = _context.CoverageItems.Find(id);
            if (oldCoverage == null)
            {
                return false;
            }
            oldCoverage = coverage;
            _context.CoverageItems.Update(oldCoverage);
            _context.SaveChanges();
            return true;
        }
    }
}
