using Domain.R;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class AppDbContext : DbContext
    {
        // public ApplicationDBContext(DbContextOptions options) : base(options)
        public AppDbContext(DbContextOptions  options) : base(options)
        {
        }
        public DbSet<ROrgType>  ROrgType { get; set; }
        public DbSet<ROrg> ROrg { get; set; }
        // public DbSet<RTerritory> RTerritory { get; set; }
    }
}