using Microsoft.Extensions.DependencyInjection;
using SelfWaiterAuth.Application.Services;
using SelfWaiterAuth.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddAuthInfrastructureService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ITokenService, TokenService>();
        }
    }
}
