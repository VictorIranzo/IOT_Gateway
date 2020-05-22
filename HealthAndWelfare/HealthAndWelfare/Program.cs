namespace HealthAndWelfare
{
    using System;
    using HealthAndWelfare.Persistence;
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            EnsureDatabaseCreated();

            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
        }

        private static void EnsureDatabaseCreated()
        {
            ServiceCollection services = new ServiceCollection();

            string databaseConnection = "Data Source=Database.db";

            services.AddDbContext<Context>(options => options
                .UseSqlite(databaseConnection));

            IServiceProvider serviceProvider = services.BuildServiceProvider();

            serviceProvider.GetService<Context>().Database.EnsureCreated();
        }
    }
}