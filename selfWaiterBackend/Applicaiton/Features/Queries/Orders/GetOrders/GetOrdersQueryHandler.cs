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
    public class GetOrdersQueryHandler : IRequestHandler<GetOrdersQueryRequest, List<GetOrdersQueryResponse>>
    {
        private readonly IOrderService _orderService;

        public GetOrdersQueryHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<List<GetOrdersQueryResponse>> Handle(GetOrdersQueryRequest request, CancellationToken cancellationToken)
        {
            List<GetOrdersQueryResponse> response = new();
            List<GetOrderDTO> getOrderDTOs = await _orderService.GetOrdersAsync(request.Page, request.Size);

            getOrderDTOs.ForEach(o =>
            {
                response.Add(new()
                {
                    BasketItems = o.BasketItems,
                    Id = o.Id,
                    Note = o.Note,
                    OrderCode = o.OrderCode,
                });
            });

            return response;

        }
    }
}
