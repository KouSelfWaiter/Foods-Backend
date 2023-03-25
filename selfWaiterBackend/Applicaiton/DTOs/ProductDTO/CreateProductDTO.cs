using Core.Applicaiton.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.DTOs.ProductDTO
{
    public class CreateProductDTO
    {
        public TranslationCode TranslationCode { get; set; }
        public string Name { get; set; }
        public string CategoryId { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
    }
}
