using Microsoft.EntityFrameworkCore;
using ORMApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ORMApp.Data
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext()
        { }
        public ProductDBContext(DbContextOptions options)
            : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(Configuration.ConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasIndex(x => x.Name).IsUnique();
            base.OnModelCreating(modelBuilder);
        }
    }
}
