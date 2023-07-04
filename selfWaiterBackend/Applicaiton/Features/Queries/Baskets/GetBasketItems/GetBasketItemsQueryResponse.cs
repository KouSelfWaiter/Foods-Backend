using Applicaiton.DTOs.BasketItemDTO;
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
        public string BasketId { get; set; }
        public string TableNo { get; set; }
        public decimal TotalPrice { get; set; }
        public List<GetBasketItemDTO> GetBasketItemDTOs { get; set; }
    }
}

