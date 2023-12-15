using Insurance.Infrastructure.Interfaces;
using Insurance.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Insurance.Infrastructure
{
    public static class DependencyInjection
    {
        public static void RegisterInfraDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<IClaimRepository, ClaimRepository>();
        }
    }
}
