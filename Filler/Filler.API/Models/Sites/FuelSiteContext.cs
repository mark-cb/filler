using Microsoft.EntityFrameworkCore;

namespace Filler.API.Models.Sites
{
    public class FuelSiteContext : DbContext
    {
        public DbSet<Site> Sites { get; set; }
        public DbSet<Pump> Pumps { get; set; }
        public DbSet<Receipt> Receipts { get; set; }

        public FuelSiteContext(DbContextOptions<FuelSiteContext> options)
           : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("FuelDb");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Site>().HasData(new Site { SiteId = 1, Latitude = 54.589752, Longitude = -1.350426, Name = "BP Durham Road", NumberOfPumps = 6 },
                    new Site { SiteId = 2, Latitude = 54.589752, Longitude = -1.350426, Name = "BP London", NumberOfPumps = 4 },
                    new Site { SiteId = 3, Latitude = 51.483875, Longitude = -0.000862, Name = "BP Trafalgar Road", NumberOfPumps = 12 }
                );

            builder.Entity<Pump>().HasData(new Pump { PumpId = 1, Number = 1, PumpSiteId = 1 },
                    new Pump { PumpId = 2, Number = 2, PumpSiteId = 1 },
                    new Pump { PumpId = 3, Number = 1, PumpSiteId = 2 },
                    new Pump { PumpId = 4, Number = 2, PumpSiteId = 2 },
                    new Pump { PumpId = 5, Number = 3, PumpSiteId = 2 },
                    new Pump { PumpId = 6, Number = 4, PumpSiteId = 2 },
                    new Pump { PumpId = 7, Number = 1, PumpSiteId = 3 },
                    new Pump { PumpId = 8, Number = 2, PumpSiteId = 3 }
                );

            builder.Entity<Pump>()
                .HasOne(s => s.PumpSite);

            builder.Entity<Site>()
                .HasMany(s => s.SitePumps)
                .WithOne(p => p.PumpSite);

            builder.Entity<Receipt>()
                .HasOne(p => p.UsedPump);
        }

    }

    public static class FuelSiteContextExtensions
    {
        public static void EnsureSeedData(this FuelSiteContext context)
        {

            if (!context.Sites.Any())
            {
                context.Sites.AddRange(
                    new Site { SiteId = 1, Latitude = 54.589752, Longitude = -1.350426, Name = "BP Durham Road", NumberOfPumps = 6 },
                    new Site { SiteId = 2, Latitude = 54.589752, Longitude = -1.350426, Name = "BP London", NumberOfPumps = 4 },
                    new Site { SiteId = 3, Latitude = 51.483875, Longitude = -0.000862, Name = "BP Trafalgar Road", NumberOfPumps = 12 }
                    );

                context.SaveChanges();
            }

            if (!context.Pumps.Any())
            {
                context.Pumps.AddRange(
                    new Pump { PumpId = 1, Number = 1, PumpSiteId = 1 },
                    new Pump { PumpId = 2, Number = 2, PumpSiteId = 1 },
                    new Pump { PumpId = 3, Number = 1, PumpSiteId = 2 },
                    new Pump { PumpId = 4, Number = 2, PumpSiteId = 2 },
                    new Pump { PumpId = 5, Number = 3, PumpSiteId = 2 },
                    new Pump { PumpId = 6, Number = 4, PumpSiteId = 2 },
                    new Pump { PumpId = 7, Number = 1, PumpSiteId = 3 },
                    new Pump { PumpId = 8, Number = 2, PumpSiteId = 3 }
                    );
                context.SaveChanges();
            }
        }

    }
}
