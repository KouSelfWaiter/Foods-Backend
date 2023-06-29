using Applicaiton.DTOs.OrderDTO;
using Applicaiton.Services.OrderService;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Queries.Orders.GetOrderById
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQueryRequest, GetOrderByIdQueryResponse>
    {
        private readonly IOrderService _orderService;

        public GetOrderByIdQueryHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<GetOrderByIdQueryResponse> Handle(GetOrderByIdQueryRequest request, CancellationToken cancellationToken)
        {
            GetOrderDTO getOrderDTO = await _orderService.GetOrderById(request.Id);

            return new()
            {
                BasketItems= getOrderDTO.BasketItems,
                Id= getOrderDTO.Id,
                Note= getOrderDTO.Note,
                OrderCode = getOrderDTO.OrderCode,
                TableNo = getOrderDTO.TableNo,
            };
        }
    }
}
