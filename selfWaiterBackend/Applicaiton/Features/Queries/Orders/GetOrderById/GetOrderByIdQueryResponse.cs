using Applicaiton.DTOs.BasketItemDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Queries.Orders.GetOrderById
{
    public class GetOrderByIdQueryResponse
    {
        public string Id { get; set; }
        public string? Note { get; set; }
        public string OrderCode { get; set; }
        public List<GetBasketItemDTO> BasketItems { get; set; }
    }
}
