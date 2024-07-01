using Microsoft.EntityFrameworkCore;
using social_nexus_api.Domain.Entities;

namespace social_nexus_api.Infrastructure
{
    public class SocialNexusDBContext : DbContext
    {
        public SocialNexusDBContext(DbContextOptions<SocialNexusDBContext> options) :
            base(options)
        { }

        public DbSet<Entity> Entities { get; set; }
        public DbSet<EntityDonation> EntitiesDonations { get; set;}
        public DbSet<EntitySector> EntitiesSectors { get; set; }
        public DbSet<EntityType> EntitiesTypes { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Headquarter> Headquarters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entity>()
                .HasOne(et => et.EntityType)
                .WithMany(t => t.Entities)
                .HasForeignKey(e => e.EntityTypeId);

            modelBuilder.Entity<Entity>()
                .HasMany(ed => ed.EntityDonations)
                .WithMany(ed => ed.Entities);
        }

    }
}
