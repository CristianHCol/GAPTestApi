using Microsoft.EntityFrameworkCore;

namespace GrowTestApi.Model
{
    public class AgencyContext : DbContext
    {
        public AgencyContext(DbContextOptions<AgencyContext> options) : base(options)
        {
        }

        public DbSet<Agency> AgencyItems { get; set; }

    }
}
