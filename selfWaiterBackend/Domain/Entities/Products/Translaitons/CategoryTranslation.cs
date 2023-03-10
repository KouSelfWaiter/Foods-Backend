using Core.Persistence.Entities;
using Core.Persistence.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Products.Translaitons
{
    public class CategoryTranslation: TranslationEntity<Category>
    {
        public string Name { get; set; }
    }
}
