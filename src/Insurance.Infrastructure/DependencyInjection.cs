using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Infrastructure
{
    public static class DependencyInjection
    {
        public static void RegisterInfraDependencies(this IServiceCollection services, IConfiguration configuration)
        {
        }
    }
}
