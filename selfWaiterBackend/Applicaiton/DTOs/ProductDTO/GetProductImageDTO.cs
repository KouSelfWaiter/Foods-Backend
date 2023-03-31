using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.DTOs.ProductDTO
{
    public class GetProductImageDTO
    {
        public string ProductId { get; set; }
        public List<ProductImageDTO> ProductImageDTOs { get; set;}
      
    }

    public class ProductImageDTO
    {
        public string ImageId { get; set; }
        public string PathOrContainer { get; set; }
        public string FileName { get; set; }
    }
}
