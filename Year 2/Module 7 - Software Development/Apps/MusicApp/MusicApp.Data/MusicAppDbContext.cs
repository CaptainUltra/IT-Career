using Microsoft.EntityFrameworkCore;
using MusicApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.Data
{
    public class MusicAppDbContext : DbContext
    {
        public MusicAppDbContext(DbContextOptions<MusicAppDbContext> options)
            :base(options)
        { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Song> Songs { get; set; }
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
            base.OnModelCreating(modelBuilder);
        }
    }
}
