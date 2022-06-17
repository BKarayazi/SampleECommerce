using SampleECommerce.Domain;
using SampleECommerce.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleECommerce.Persistence
{
    public class SampleECommerceDbContext : AuditableDbContext
    {
        public SampleECommerceDbContext(DbContextOptions<SampleECommerceDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SampleECommerceDbContext).Assembly);
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Offer> Offers { get; set; }
    }
}
