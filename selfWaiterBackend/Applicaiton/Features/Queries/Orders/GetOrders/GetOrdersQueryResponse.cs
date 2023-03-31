﻿using Applicaiton.DTOs.BasketItemDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Queries.Orders.GetOrders
{
    public class GetOrdersQueryResponse
    {
        //public string Id { get; set; }
        //public string? Note { get; set; }
        //public string OrderCode { get; set; }
        //public List<GetBasketItemDTO> BasketItems { get; set; }

        public List<object> Orders { get; set; }

        public int TotalCount { get; set; }

    }
}
