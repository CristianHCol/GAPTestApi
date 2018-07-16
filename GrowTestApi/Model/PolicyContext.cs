using Microsoft.EntityFrameworkCore;

namespace GrowTestApi.Model
{
    public class PolicyContext: DbContext
    {
        public PolicyContext(DbContextOptions<PolicyContext> options) : base(options)
        {
        }

        public DbSet<Policy> PolicyItems { get; set; }

    }
}
