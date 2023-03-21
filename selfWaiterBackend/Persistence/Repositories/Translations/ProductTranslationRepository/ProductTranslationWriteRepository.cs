using Applicaiton.Services.Repositories.Translations.ProductTranslationRepository;
using Domain.Entities.Products.Translaitons;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.Translations.ProductTranslationRepository
{
    public class ProductTranslationWriteRepository : WriteRepository<ProductTranslation>, IProductTranslationWriteRepository
    {
        public ProductTranslationWriteRepository(SelfWaiterDbContext context) : base(context)
        {
        }
    }
}
