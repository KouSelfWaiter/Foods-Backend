﻿using Applicaiton.DTOs.ProductDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Queries.Products.GetAllProducts
{
    public class GetAllProductsQueryResponse
    {
        //public string Id { get; set; }
        //public string CategoryId { get; set; }
        //public decimal Price { get; set; }
        //public bool IsActive { get; set; }
        //public List<GetProductTranslationDTO> Translation { get; set; }

        public List<GetProductDTO> Products { get; set; }
        public int TotalCount { get; set; }
    }
}
