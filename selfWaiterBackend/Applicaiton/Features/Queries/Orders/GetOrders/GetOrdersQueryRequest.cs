using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Queries.Orders.GetOrders
{
    public class GetOrdersQueryRequest: IRequest<GetOrdersQueryResponse>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 10;
    }
}
