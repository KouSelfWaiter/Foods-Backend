using Applicaiton.DTOs.ProductDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Queries.Products.GetProductImages
{
    public class GetProductImagesQueryResponse
    {
        public string ProductId { get; set; }
        public List<ProductImageDTO> ProductImageDTOs { get; set; }
    }
}
