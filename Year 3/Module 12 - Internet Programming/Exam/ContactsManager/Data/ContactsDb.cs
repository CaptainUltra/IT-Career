using Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ContactsDb : DbContext
    {
        public virtual DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ContactsDb;");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
