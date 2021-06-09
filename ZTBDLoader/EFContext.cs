using Microsoft.EntityFrameworkCore;
using ZTBDLoader.model;

namespace ZTBDLoader
{
    public class EFContext : DbContext
    {

        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=Ksiazki;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Checkouts> Checkouts { get; set; }
        public DbSet<CollectionInventory> CollectionInventory { get; set; }
        public DbSet<DataDictionary> DataDictionary { get; set; }

    }
}
