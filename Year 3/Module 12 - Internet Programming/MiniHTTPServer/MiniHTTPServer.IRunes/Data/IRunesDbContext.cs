using Microsoft.EntityFrameworkCore;
using MiniHTTPServer.IRunes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniHTTPServer.IRunes.Data
{
    public class IRunesDbContext : DbContext
    {
        public DbSet<Album> Albums { get; private set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=IRunesDB;Trusted_Connection=True;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
