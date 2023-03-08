using Core.Persistence.Entities;
using Domain.Entities.Products.Translaitons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Products
{
    public class ProductOption : ModelEntity<ProductOptionsTranslation> 
    {
        public decimal Price { get; set; }
    }
}
