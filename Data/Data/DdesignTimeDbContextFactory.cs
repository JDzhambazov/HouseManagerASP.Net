namespace Data
{
    using System.IO;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Configuration.Json;

    public class DdesignTimeDbContextFactory
        : IDesignTimeDbContextFactory<HouseManagerDbContext>
    {
        public HouseManagerDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var optionsBuilder = new DbContextOptionsBuilder<HouseManagerDbContext>();

            optionsBuilder.UseSqlServer(configuration.
                GetConnectionString("DefaultConnection"));

            return new HouseManagerDbContext(optionsBuilder.Options);
        }
    }
}
