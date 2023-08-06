using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SelfWaiterAuth.Application.Repositories.UserRefreshTokenRepository;
using SelfWaiterAuth.Application.Services;
using SelfWaiterAuth.Domain.Entities;
using SelfWaiterAuth.Persistence.Context;
using SelfWaiterAuth.Persistence.Repositories.UserRefreshTokenRepository;
using SelfWaiterAuth.Persistence.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddAuthPersistenceService(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<AppDbContext>(options => options.UseNpgsql(configuration["ConnectionStrings:PostgreSQL"]));

            serviceCollection.AddIdentity<UserApp, IdentityRole<string>>(options =>
            {
                options.User.RequireUniqueEmail = true;
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
            //TokenProvider for reset password operations

            serviceCollection.AddScoped<IUserRefreshTokenRepository, UserRefreshTokenRepository>();
            serviceCollection.AddScoped<IUserService, UserService>();
            serviceCollection.AddScoped<IAuthenticationService, AuthenticationService>();
        }
    }
}
