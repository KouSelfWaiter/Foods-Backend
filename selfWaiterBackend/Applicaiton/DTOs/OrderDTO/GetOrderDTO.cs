using Applicaiton.DTOs.BasketItemDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.DTOs.OrderDTO
{
    public class GetOrderDTO
    {
        public string Id { get; set; }
        public string Note { get; set; }
        public string OrderCode { get; set; }
        public List<GetBasketItemDTO> BasketItems { get; set; }
        public int TotalCount { get; set; }
        public decimal TotalPrice { get; set; }
        public string TableNo { get; set; }
    }
}
