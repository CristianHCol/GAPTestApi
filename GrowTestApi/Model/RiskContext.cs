using Microsoft.EntityFrameworkCore;

namespace GrowTestApi.Model
{
    public class RiskContext : DbContext
    {
        public RiskContext(DbContextOptions<RiskContext> options) : base(options)
        {
        }

        public DbSet<Risk> RiskItems { get; set; }

    }
}
