using Applicaiton.Services.Repositories.CategoryRepository;
using Applicaiton.Services.Repositories.ProductOptionRepository;
using Applicaiton.Services.Repositories.ProductRepository;
using Applicaiton.Services.Repositories.SpecialMenuRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories.CategoryRepository;
using Persistence.Repositories.ProductOptionRepository;
using Persistence.Repositories.ProductRepository;
using Persistence.Repositories.SpecialMenuRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<SelfWaiterDbContext>(options =>
                options.UseNpgsql(configuration["ConnectionStrings:PostgreSQL"]));

            serviceCollection.AddScoped<IProductReadRepository, ProductReadRepository>();
            serviceCollection.AddScoped<IProductWriteRepository, ProductWriteRepository>();

            serviceCollection.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            serviceCollection.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();

            serviceCollection.AddScoped<IProductOptionReadRepository, ProductOptionReadRepository>();
            serviceCollection.AddScoped<IProductOptionWriteRepository, ProductOptionWriteRepository>();

            serviceCollection.AddScoped<ISpecialMenuReadRepository, SpecialMenuReadRepository>();
            serviceCollection.AddScoped<ISpecialMenuWriteRepository, SpecialMenuWriteRepository>();
        }

    }
}
