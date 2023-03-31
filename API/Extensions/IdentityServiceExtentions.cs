using Domain;
using Persistence;

namespace API.Extensions
{
    public static class IdentityServiceExtentions
    {
        public static IServiceCollection AddIdentityServices( this IServiceCollection services,
        IConfiguration config)
        {
            services.AddIdentityCore<AppUser>( opt => 
            {
                opt.Password.RequiredLength = 6;
            })
            .AddEntityFrameworkStores<AppDbContext>();
            services.AddAuthentication();
            return services;
        }
    }
}