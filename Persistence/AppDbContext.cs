using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<OrgType> OrgType { get; set; }
        public DbSet<Org> Org { get; set; }
    }
}