using Applicaiton.Services.Repositories.Translations.ProductOptionsTranslationRepository;
using Domain.Entities.Products.Translaitons;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.Translations.ProductOptionsTranslationRepository
{
    public class ProductOptionsTranslationReadRepository : ReadRepository<ProductOptionsTranslation>, IProductOptionTranslationReadRepository
    {
        public ProductOptionsTranslationReadRepository(SelfWaiterDbContext context) : base(context)
        {
        }
    }
}
