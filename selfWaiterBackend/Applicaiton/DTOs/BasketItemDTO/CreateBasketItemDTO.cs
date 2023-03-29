using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.DTOs.BasketItemDTO
{
    public class CreateBasketItemDTO
    {
        public int Quantity { get; set; }
        public string ProductId { get; set; }
    }
}
