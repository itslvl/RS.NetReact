
using AutoMapper;
using Domain;
using Domain.DomainDto;
using DomainDto;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace Persistence

{
    public class Seed
    {
        // private readonly AppDbContext _context;
        // private readonly IMapper _mapper;

        // public Seed(AppDbContext context, IMapper mapper)
        // {
        //     _mapper = mapper;
        //     _context = context;
        // }

        // public static async Task SeedAll()
        // {
        //     var seed = new Seed(_context, _mapper);
        //     await seed.SeedData(userManager);
        //     await SeedOrgType();
        //     await SeedZone();
        //     return;
        // }
        public static async Task SeedData(UserManager<AppUser> userManager,
        AppDbContext context)
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

            var orgTypeString = "";
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

        public static async Task SeedZone(AppDbContext context)
        {


            if (context.Zone.Any()) return;
            string jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "SeedFiles\\ZoneSeed.Json");
            string jsonData = File.ReadAllText(jsonFilePath);
            ZoneDto[] zoneDto = JsonConvert.DeserializeObject<ZoneDto[]>(jsonData);
            IMapper mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ZoneDto, Zone>();
            }).CreateMapper();

            var zones = mapper.Map<Zone[]>(zoneDto);
            foreach (var zone in zones)
            {
                context.Zone.Add(zone);
            }
            await context.SaveChangesAsync();
            return;
        }

        public static async Task SeedLocationType(AppDbContext context)
        {


            if (context.LocationType.Any()) return;
            string jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "SeedFiles\\LocationTypeSeed.Json");
            string jsonData = File.ReadAllText(jsonFilePath);
            LocationTypeDto[] locationTypeDto = JsonConvert.DeserializeObject<LocationTypeDto[]>(jsonData);
            IMapper mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<LocationTypeDto, LocationType>();
            }).CreateMapper();

            var locationTypes = mapper.Map<LocationType[]>(locationTypeDto);
            foreach (var locationType in locationTypes)
            {
                context.LocationType.Add(locationType);
            }
            await context.SaveChangesAsync();
            return;
        }

        public static async Task SeedAgama(AppDbContext context)
        {


            if (context.Agama.Any()) return;
            string jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(),
                "SeedFiles\\AgamaSeed.Json");
            string jsonData = File.ReadAllText(jsonFilePath);
            AgamaDto[] agamaDto = JsonConvert.DeserializeObject<AgamaDto[]>(jsonData);
            IMapper mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AgamaDto, Agama>();
            }).CreateMapper();

            var agamas = mapper.Map<Agama[]>(agamaDto);
            foreach (var agama in agamas)
            {
                context.Agama.Add(agama);
            }
            await context.SaveChangesAsync();
            return;
        }


        public static async Task SeedBahasa(AppDbContext context)
        {


            if (context.Bahasa.Any()) return;
            string jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(),
                "SeedFiles\\BahasaSeed.Json");
            string jsonData = File.ReadAllText(jsonFilePath);
            BahasaDto[] bahasaDto = JsonConvert.DeserializeObject<BahasaDto[]>(jsonData);
            IMapper mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BahasaDto, Bahasa>();
            }).CreateMapper();

            var bahasas = mapper.Map<Bahasa[]>(bahasaDto);
            foreach (var bahasa in bahasas)
            {
                context.Bahasa.Add(bahasa);
            }
            await context.SaveChangesAsync();
            return;
        }

        public static async Task SeedGender(AppDbContext context)
        {

            if (!context.Gender.Any())
            {
                var lst = new List<Gender>
                    {
                        new Gender{Uraian="Laki-laki"},
                        new Gender{Uraian="Perempuan"},
                        new Gender{Uraian="Tidak diketahui"},
                        new Gender{Uraian="---"}
                    };
                foreach (var row in lst)
                {
                    context.Gender.Add(row);
                }
            }
            await context.SaveChangesAsync();
            return;
        }

         public static async Task SeedGolongan(AppDbContext context)
        {


            if (context.Golongan.Any()) return;
            string jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(),
                "SeedFiles\\GolonganSeed.Json");
            string jsonData = File.ReadAllText(jsonFilePath);
            GolonganSeedDto[] golonganDto = JsonConvert.DeserializeObject<GolonganSeedDto[]>(jsonData);
            IMapper mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<GolonganSeedDto, Golongan>()
                .ForMember(dest => dest.UraianGolongan, 
                    opt => opt.MapFrom(src => src.Uraian))
                .ForMember(dest => dest.UraianPangkat, 
                    opt => opt.MapFrom(src => src.Uraian2))
                ;
            }).CreateMapper();

            var golongans = mapper.Map<Golongan[]>(golonganDto);
            foreach (var golongan in golongans)
            {
                context.Golongan.Add(golongan);
            }
            await context.SaveChangesAsync();
            return;
        }
    }
}