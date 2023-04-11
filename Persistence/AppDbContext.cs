using Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<OrgType> OrgType { get; set; }
        public DbSet<Org> Org { get; set; }
        public DbSet<Zone> Zone { get; set; }
        public DbSet<LocationType> LocationType { get; set; }
        public DbSet<Location> Location { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // builder.Entity<Org>( a => a.HasKey( aa => new { aa.OrgTypeID}));

            builder.Entity<Org>()
            .HasOne(u => u.OrgType)
            .WithMany(u => u.Org)
            .HasForeignKey(u => u.OrgTypeID);

            builder.Entity<Location>()
            .HasOne(u => u.LocationType)
            .WithMany(u => u.Location)
            .HasForeignKey(u => u.LocationTypeId);

             builder.Entity<Location>()
            .HasOne(u => u.Zone)
            .WithMany(u => u.Location)
            .HasForeignKey(u => u.ZoneId);
            
        }
    }
}