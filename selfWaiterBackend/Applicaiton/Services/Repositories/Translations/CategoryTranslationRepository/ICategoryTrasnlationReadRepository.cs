﻿using Core.Persistence.Repositories;
using Domain.Entities.Products.Translaitons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Services.Repositories.Translations.CategoryTranslationRepository
{
    public interface ICategoryTrasnlationReadRepository : IReadRepository<CategoryTranslation>
    {
    }
}
