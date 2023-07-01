using Applicaiton.HubsServices;
using Microsoft.Extensions.DependencyInjection;
using SelfWaiterSignalR.HubServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterSignalR
{
    public static class ServiceRegistration
    {
        public static void AddSignalRService(this IServiceCollection serviceCollection)
        {
            //added SignalR
            serviceCollection.AddSignalR();

            serviceCollection.AddTransient<IOrderHubService, OrderHubService>();
        }
    }
}
