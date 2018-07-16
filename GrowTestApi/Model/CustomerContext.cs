using Microsoft.EntityFrameworkCore;

namespace GrowTestApi.Model
{
    public class CustomersContext : DbContext
    {
        public CustomersContext(DbContextOptions<CustomersContext> options) : base(options)
        {
        }

        public DbSet<Customer> CustomerItems { get; set; }

    }
}
