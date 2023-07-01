using Microsoft.AspNetCore.Builder;
using SelfWaiterSignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterSignalR
{
    public static class HubsRegistration
    {
        public static void MapHubs(this WebApplication webApplication)
        {
            webApplication.MapHub<OrderHub>("/orderHub");
        }
    }
}
