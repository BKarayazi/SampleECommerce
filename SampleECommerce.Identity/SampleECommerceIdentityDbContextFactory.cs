using SampleECommerce.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SampleECommerce.Persistence
{
    public class SampleECommerceIdentityDbContextFactory : IDesignTimeDbContextFactory<SampleECommerceIdentityDbContext>
    {
        public SampleECommerceIdentityDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<SampleECommerceIdentityDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseSqlServer(connectionString);

            return new SampleECommerceIdentityDbContext(builder.Options);
        }
    }
}
