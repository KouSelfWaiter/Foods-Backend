using Applicaiton.DTOs.OrderDTO;
using Applicaiton.Services.OrderService;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Queries.Orders.GetOrders
{
    public class GetOrdersQueryHandler : IRequestHandler<GetOrdersQueryRequest, GetOrdersQueryResponse>
    {
        private readonly IOrderService _orderService;

        public GetOrdersQueryHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<GetOrdersQueryResponse> Handle(GetOrdersQueryRequest request, CancellationToken cancellationToken)
        {
            List<object> orders = new();
            List<GetOrderDTO> getOrderDTOs = await _orderService.GetOrdersAsync(request.Page, request.Size);
            int totalCount = 0;
            getOrderDTOs.ForEach(o =>
            {
                orders.Add(new
                {
                    o.Id,
                    o.Note,
                    o.OrderCode,
                    o.BasketItems,
                });

                totalCount = o.TotalCount;
            });

            return new()
            {
                Orders = orders,
                TotalCount = totalCount
            };

        }
    }
}
