using Microsoft.EntityFrameworkCore;

namespace GrowTestApi.Model
{
    public class AuthenticationContext : DbContext
    {
        public AuthenticationContext(DbContextOptions<AuthenticationContext> options) : base(options)
        {
        }

        public DbSet<User> AuthenticationItems { get; set; }

    }
}
