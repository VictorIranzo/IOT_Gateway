namespace Billing.Persistence
{
    using Microsoft.EntityFrameworkCore;

    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base (options)
        {
        }

        public DbSet<Bill> Bills { get; set; }

        public DbSet<Client> Clients { get; set; }
    }
}