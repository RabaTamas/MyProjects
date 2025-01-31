using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Otthonbazar.Data.EntityTypeConfigurations;

namespace Otthonbazar.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<City> Cityies => Set<City>();
        public DbSet<Advertisement> Advertisements => Set<Advertisement>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new CitySeedConfig());
            builder.ApplyConfiguration(new AdvertisementSeedConfig());
        }
    }
}
