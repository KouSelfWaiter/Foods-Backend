using Applicaiton.Services.Repositories.Translations.CategoryTranslationRepository;
using Domain.Entities.Products.Translaitons;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.Translations.CategoryTranslationRepository
{
    public class CategoryTranslationReadRepository : ReadRepository<CategoryTranslation>, ICategoryTrasnlationReadRepository
    {
        public CategoryTranslationReadRepository(SelfWaiterDbContext context) : base(context)
        {
        }
    }
}
