
using Domain;
using Microsoft.AspNetCore.Identity;

namespace Persistence

{
    public class Seed
    {
        public static async Task SeedData(AppDbContext context,
        UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var users = new List<AppUser>
                    {
                        new AppUser{DisplayName = "Satu",  UserName="NamaSatu", Email ="satu@satu.com"},
                        new AppUser{DisplayName = "Dua",  UserName="NamaDua", Email ="dua@dua.com"},
                        new AppUser{DisplayName = "Tiga", UserName="NamaTiga", Email ="tiga@tiga.com"}
                    };
                    foreach (var user in users)
                    {
                        await userManager.CreateAsync(user,"Pa$$w0d");
                    }
            }

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