using Applicaiton.Services.Repositories.Translations.SpecialMenuTranslationRepository;
using Domain.Entities.Products.Translaitons;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.Translations.SpecialMenuTranslationRepository
{
    public class SpecialMenuTranslationReadRepository : ReadRepository<SpecialMenuTranslation>, ISpecialMenuTranslationReadRepository
    {
        public SpecialMenuTranslationReadRepository(SelfWaiterDbContext context) : base(context)
        {
        }
    }
}
