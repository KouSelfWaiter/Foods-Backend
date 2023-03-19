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
    public class CategoryTranslationWriteRepository : WriteRepository<CategoryTranslation>, ICategoryTranslationWriteRepository
    {
        public CategoryTranslationWriteRepository(SelfWaiterDbContext context) : base(context)
        {
        }
    }
}
