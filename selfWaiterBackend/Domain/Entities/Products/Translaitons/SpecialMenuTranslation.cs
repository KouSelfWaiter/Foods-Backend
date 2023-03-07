using Core.Persistence.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Products.Translaitons
{
    public class SpecialMenuTranslation : TranslationEntity<SpecialMenu>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
