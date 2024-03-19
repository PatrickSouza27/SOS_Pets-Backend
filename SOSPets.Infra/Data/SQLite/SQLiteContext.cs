using Microsoft.EntityFrameworkCore;
using SOSPets.Domain.Models;
using SOSPets.Infra.Data.SQLite.Mapping;

namespace SOSPets.Infra.Data.SQLite
{
    public class SQLiteContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new ContactMap());

        }

    }
}
