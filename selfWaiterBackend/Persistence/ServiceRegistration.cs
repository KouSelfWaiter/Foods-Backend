using Applicaiton.Services.BasketService;
using Applicaiton.Services.CategoryService;
using Applicaiton.Services.FileService;
using Applicaiton.Services.OrderService;
using Applicaiton.Services.ProductService;
using Applicaiton.Services.Repositories.BasketItemRepository;
using Applicaiton.Services.Repositories.BasketRepository;
using Applicaiton.Services.Repositories.CategoryRepository;
using Applicaiton.Services.Repositories.ImageFileRepository;
using Applicaiton.Services.Repositories.OrderRepository;
using Applicaiton.Services.Repositories.ProductOptionRepository;
using Applicaiton.Services.Repositories.ProductRepository;
using Applicaiton.Services.Repositories.SpecialMenuRepository;
using Applicaiton.Services.Repositories.Translations.CategoryTranslationRepository;
using Applicaiton.Services.Repositories.Translations.ProductOptionsTranslationRepository;
using Applicaiton.Services.Repositories.Translations.ProductTranslationRepository;
using Applicaiton.Services.Repositories.Translations.SpecialMenuTranslationRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories.BasketItemRepository;
using Persistence.Repositories.BasketRepository;
using Persistence.Repositories.CategoryRepository;
using Persistence.Repositories.ImageFileRepository;
using Persistence.Repositories.OrderRepository;
using Persistence.Repositories.ProductOptionRepository;
using Persistence.Repositories.ProductRepository;
using Persistence.Repositories.SpecialMenuRepository;
using Persistence.Repositories.Translations.CategoryTranslationRepository;
using Persistence.Repositories.Translations.ProductOptionsTranslationRepository;
using Persistence.Repositories.Translations.ProductTranslationRepository;
using Persistence.Repositories.Translations.SpecialMenuTranslationRepository;
using Persistence.Services.BasketService;
using Persistence.Services.CategoryService;
using Persistence.Services.FileService;
using Persistence.Services.OrderService;
using Persistence.Services.ProductService;
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

            serviceCollection.AddScoped<ICategoryTrasnlationReadRepository, CategoryTranslationReadRepository>();
            serviceCollection.AddScoped<ICategoryTranslationWriteRepository, CategoryTranslationWriteRepository>();

            serviceCollection.AddScoped<IProductOptionTranslationReadRepository, ProductOptionsTranslationReadRepository>();
            serviceCollection.AddScoped<IProductOptionsTranslationWriteRepository, ProductOptionsTranslationWriteRepository>();

            serviceCollection.AddScoped<IProductTranslationReadRepository, ProductTranslationReadRepository>();
            serviceCollection.AddScoped<IProductTranslationWriteRepository, ProductTranslationWriteRepository>();

            serviceCollection.AddScoped<ISpecialMenuTranslationReadRepository, SpecialMenuTranslationReadRepository>();
            serviceCollection.AddScoped<ISpecialMenuTranslationWriteRepository, SpecialMenuTranslationWriteRepository>();

            serviceCollection.AddScoped<IImageFileReadRepository, ImageFileReadRepository>();
            serviceCollection.AddScoped<IImageFileWriteRepository, ImageFileWriteRepository>();

            serviceCollection.AddScoped<IBasketReadRepository, BasketReadRepository>();
            serviceCollection.AddScoped<IBasketWriteRepository, BasketWriteRepository>();

            serviceCollection.AddScoped<IBasketItemReadRepository, BasketItemReadRepository>();
            serviceCollection.AddScoped<IBasketItemWriteRepository, BasketItemWriteRepository>();

            serviceCollection.AddScoped<IOrderReadRepository, OrderReadRepository>();
            serviceCollection.AddScoped<IOrderWriteRepository, OrderWriteRepository>();


            serviceCollection.AddScoped<ICategoryService, CategoryService>();

            serviceCollection.AddScoped<IProductService, ProductService>();

            serviceCollection.AddScoped<IBasketService, BasketService>();

            serviceCollection.AddScoped<IOrderService, OrderService>();

            serviceCollection.AddScoped<IFileService, FileService>();

        }

    }
}
