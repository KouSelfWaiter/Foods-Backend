using Core.Persistence.Entities;
using Domain.Entities.Products.Translaitons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Products
{
    public class Category: ModelEntity<CategoryTranslation>
    {
        public Category()
        {
            Products = new List<Product>();
        }
        public ICollection<Product> Products { get; set; }
    }
}
