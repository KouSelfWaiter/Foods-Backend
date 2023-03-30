using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.DTOs.OrderDTO
{
    public class CreateOrderDTO
    {
        public string? Note { get; set; }
        public string BasketId { get; set; }
    }
}
