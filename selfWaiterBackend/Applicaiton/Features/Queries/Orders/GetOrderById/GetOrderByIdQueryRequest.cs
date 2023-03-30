using Applicaiton.DTOs.BasketItemDTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Queries.Orders.GetOrderById
{
    public class GetOrderByIdQueryRequest: IRequest<GetOrderByIdQueryResponse>
    {
        public string Id { get; set; }
    }
}
