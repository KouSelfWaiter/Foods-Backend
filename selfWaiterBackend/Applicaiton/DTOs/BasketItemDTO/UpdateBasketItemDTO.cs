using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.DTOs.BasketItemDTO
{
    public class UpdateBasketItemDTO
    {
        public string BasketItemId { get; set; }
        public int Quantity { get; set; }
    }
}
