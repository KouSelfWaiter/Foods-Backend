
using Core.Persistence.Entities;
using Domain.Entities.Baskets;
using Domain.Entities.Files;
using Domain.Entities.Products.Translaitons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Products
{
    public class Product : ModelEntity<ProductTranslation>
    {
        public decimal Price { get; set; }

        public ICollection<ProductOption> ProductOptions { get; set; }
        public ICollection<SpecialMenu> SpecialMenus { get; set; }
        public Category Category { get; set; }
        public ICollection<ImageFile> ImageFiles { get; set; }
        public ICollection<BasketItem> BasketItems { get; set; }
    }
}
