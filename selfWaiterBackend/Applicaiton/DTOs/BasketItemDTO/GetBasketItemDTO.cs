﻿using Applicaiton.DTOs.ProductDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.DTOs.BasketItemDTO
{
    public class GetBasketItemDTO
    {
        public string Id { get; set; }
        public GetProductDTO ProductDTO { get; set; }
        public int Quantity { get; set; }
    }
}
