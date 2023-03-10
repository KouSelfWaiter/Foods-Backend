﻿using Core.Persistence.Entities;

namespace Domain.Entities.Baskets
{
    public class Basket: ModelEntity
    {
        public string TableNo { get; set; }
        public ICollection<BasketItem> BasketItems { get; set; }
        public Order Order { get; set; }
    }
}