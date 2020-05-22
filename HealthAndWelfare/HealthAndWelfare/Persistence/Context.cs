namespace HealthAndWelfare.Persistence
{
    using Microsoft.EntityFrameworkCore;

    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Treatment> Treatments { get; set; }

        public DbSet<User> Users { get; set; }
    }
}