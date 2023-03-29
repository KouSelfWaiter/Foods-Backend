using Applicaiton.DTOs.ProductDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Queries.Baskets.GetBasketItems
{
    public class GetBasketItemsQueryResponse
    {
        public string TableNo { get; set; }
        public List<GetProductTranslationDTO> ProductTranslation { get; set; }
        public int Quantity { get; set; }
    }
}
