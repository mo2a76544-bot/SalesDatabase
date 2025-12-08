using Microsoft.EntityFrameworkCore;
using SalesDatabase.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesDatabase.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {   
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=BikeStores524;Connect Timeout=30;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;");   
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Model.customer> Customers { get; set; }
        public DbSet<Model.product> Products { get; set; }
        public DbSet<Model.sale> Sales { get; set; }
        public DbSet<Model.store> Stores { get; set; }
        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<product>(e =>
            {
                e.Property(p => p.Name).HasMaxLength(50).IsUnicode();
            });

            model.Entity<customer>(e =>
            {
                e.Property(c => c.Name).HasMaxLength(100).IsUnicode();
                e.Property(c => c.Email).HasMaxLength(80).IsUnicode(false);
            });

            model.Entity<store>(e =>
            {
                e.Property(s => s.Name).HasMaxLength(80).IsUnicode();
            });
        }
    }
}
