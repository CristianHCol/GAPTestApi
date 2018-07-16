using Microsoft.EntityFrameworkCore;

namespace GrowTestApi.Model
{
    public class CoverageTypesContext : DbContext
    {
        public CoverageTypesContext(DbContextOptions<CoverageTypesContext> options) : base(options)
        {
        }

        public DbSet<CoverageType> CoverageItems { get; set; }

    }
}
