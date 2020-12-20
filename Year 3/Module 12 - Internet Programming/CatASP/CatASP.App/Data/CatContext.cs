using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CatASP.App.Models;

namespace CatASP.App.Data
{
    public class CatContext : DbContext
    {
        public CatContext (DbContextOptions<CatContext> options)
            : base(options)
        {
        }

        public DbSet<CatASP.App.Models.Cat> Cat { get; set; }
    }
}
