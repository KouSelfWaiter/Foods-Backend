using Applicaiton.HubsServices;
using Microsoft.AspNetCore.SignalR;
using SelfWaiterSignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterSignalR.HubServices
{
    public class OrderHubService: IOrderHubService
    {
        private readonly IHubContext<OrderHub> _hubContext;

        public OrderHubService(IHubContext<OrderHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task OrderAddedMessageAsync(string message)
        {
            await _hubContext.Clients.All.SendAsync(ReceiveFunctionName.OrderAddedMessage, message);
        }
    }
}
