using SampleECommerce.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SampleECommerce.Identity.Configurations;
using System.Collections.Generic;
using System.Text;

namespace SampleECommerce.Identity
{
    public class SampleECommerceIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public SampleECommerceIdentityDbContext(DbContextOptions<SampleECommerceIdentityDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
        }
    }
}
