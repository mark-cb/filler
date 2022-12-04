using Microsoft.EntityFrameworkCore;

namespace Filler.API.Models.Sites
{
    public class FuelSiteContext : DbContext
    {
        public DbSet<Site> Sites { get; set; }
        public DbSet<Pump> Pumps { get; set; }
        public DbSet<Receipt> Receipts { get; set; }


        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "FuelDb");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Pump>()
                .HasOne<Site>(s => s.PumpSite);

        }

    }
}
