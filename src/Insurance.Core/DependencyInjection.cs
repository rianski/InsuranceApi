using AutoMapper;
using Insurance.Core.Interfaces;
using Insurance.Core.Mappers;
using Insurance.Core.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Insurance.Core
{
    public static class DependencyInjection
    {
        public static void RegisterCoreDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            var mapperConfig = new MapperConfiguration(mapperConfig =>
            {
                mapperConfig.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();

            services.AddSingleton(mapper);
            services.AddScoped<ICompanyService, CompanyService>();
        }
    }
}
