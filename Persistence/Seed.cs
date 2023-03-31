
using Domain;
namespace Persistence

{
    public class Seed
    {
        public static async Task SeedOrgType(AppDbContext context)
        {
            if (context.OrgType.Any()) return;
            var lstROrgType = new List<OrgType>
            {
                new OrgType
                {
                    // Id = 1,
                    Deleted = 0,
                    SaveDate = DateTime.UtcNow,
                    Code = "prov",
                    Display = "Healthcare Provider",
                    Definition = "An organization that provides healthcare services."
                },
                new OrgType
                {
                    // Id = 2,
                    Deleted = 0,
                    SaveDate = DateTime.UtcNow,
                    Code = "dept",
                    Display = "Hospital Department",
                    Definition = "A department or ward within a hospital (Generally is not applicable to top level organizations)"

                }
            };
            await context.OrgType.AddRangeAsync(lstROrgType);
            await context.SaveChangesAsync();
            return;
        }
    }
}