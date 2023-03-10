using Core.Persistence.Entities;
using Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Baskets
{
    public class BasketItem: ModelEntity
    {
        public int Quantity { get; set; }
        public Basket Basket { get; set; }
        public Product Product { get; set; }
    }
}
