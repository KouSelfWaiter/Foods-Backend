using Core.Persistence.Entities;
using Core.Persistence.Repositories.Entities;
using Domain.Entities.Products.Translaitons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Products
{
    public class SpecialMenu:ModelEntity<SpecialMenuTranslation>
    {
        public decimal Price { get; set; }
        public bool HasBeverage { get; set; }

    }
}
