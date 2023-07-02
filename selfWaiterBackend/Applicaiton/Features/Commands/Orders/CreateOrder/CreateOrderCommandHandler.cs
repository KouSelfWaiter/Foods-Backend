using Applicaiton.HubsServices;
using Applicaiton.Services.OrderService;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Orders.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommandRequest, CreateOrderCommandResponse>
    {
        private readonly IOrderService _orderService;
        private readonly IOrderHubService _orderHubService;

        public CreateOrderCommandHandler(IOrderService orderService, IOrderHubService orderHubService)
        {
            _orderService = orderService;
            _orderHubService = orderHubService;
        }

        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            await _orderService.CreateOrderAsync(new()
            {
                BasketId= request.BasketId,
                Note = request.Note,
            });

            await _orderHubService.OrderAddedMessageAsync("Yeni Sipariş Var !!!");

            return new();
        }
    }
}
