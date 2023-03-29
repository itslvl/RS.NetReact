using Domain.R;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedOrgType(AppDbContext context)
        {
            if (context.ROrgType.Any()) return;
            var lstROrgType = new List<ROrgType>
            {
                new ROrgType
                {
                    // Id = 1,
                    Deleted = 0,
                    SaveDate = DateTime.UtcNow,
                    Code = "prov",
                    Display = "Healthcare Provider",
                    Definition = "An organization that provides healthcare services."
                },
                new ROrgType
                {
                    // Id = 2,
                    Deleted = 0,
                    SaveDate = DateTime.UtcNow,
                    Code = "dept",
                    Display = "Hospital Department",
                    Definition = "A department or ward within a hospital (Generally is not applicable to top level organizations)"

                }
            };
            await context.ROrgType.AddRangeAsync(lstROrgType);
            await context.SaveChangesAsync();
            return;
        }
    }
}