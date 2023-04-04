
using Domain;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

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
                    await userManager.CreateAsync(user, "Pa$$w0d");
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

        public static async Task SeedOrgType(AppDbContext context)
        {
            if (context.OrgType.Any()) return;
            var orgTypeString = "{\"concept\":[{\"code\":\"prov\",\"display\":\"Healthcare Provider\",\"definition\":\"An organization that provides healthcare services.\"},{\"code\":\"dept\",\"display\":\"Hospital Department\",\"definition\":\"A department or ward within a hospital (Generally is not applicable to top level organizations)\"},{\"code\":\"team\",\"display\":\"Organizational team\",\"definition\":\"An organizational team is usually a grouping of practitioners that perform a specific function within an organization (which could be a top level organization, or a department).\"},{\"code\":\"govt\",\"display\":\"Government\",\"definition\":\"A political body, often used when including organization records for government bodies such as a Federal Government, State or Local Government.\"},{\"code\":\"ins\",\"display\":\"Insurance Company\",\"definition\":\"A company that provides insurance to its subscribers that may include healthcare related policies.\"},{\"code\":\"pay\",\"display\":\"Payer\",\"definition\":\"A company, charity, or governmental organization, which processes claims and or issues payments to providers on behalf of patients or groups of patients.\"},{\"code\":\"edu\",\"display\":\"Educational Institute\",\"definition\":\"An educational institution that provides education or research facilities.\"},{\"code\":\"reli\",\"display\":\"Religious Institution\",\"definition\":\"An organization that is identified as a part of a religious institution.\"},{\"code\":\"crs\",\"display\":\"Clinical Research Sponsor\",\"definition\":\"An organization that is identified as a Pharmaceutical Clinical Research Sponsor.\"},{\"code\":\"cg\",\"display\":\"Community Group\",\"definition\":\"An un-incorporated community group.\"},{\"code\":\"bus\",\"display\":\"Non-Healthcare Business or Corporation\",\"definition\":\"An organization that is a registered business or corporation but not identified by other types.\"},{\"code\":\"other\",\"display\":\"Other\",\"definition\":\"Other type of organization not already specified.\"}]}";
            var rootObject = JsonConvert.DeserializeObject<RootObject>(orgTypeString);
            var listOrgType = new List<OrgType>();
            foreach (var item in rootObject.concept)
            {
                var orgType = new OrgType
                {
                    Id = Guid.NewGuid(),
                    Code = item.Code,
                    Display = item.Display,
                    Definition = item.Definition,
                    Deleted = 0
                };
                listOrgType.Add(orgType);
            }
            await context.OrgType.AddRangeAsync(listOrgType);
            await context.SaveChangesAsync();
            return;
        }
    }
}