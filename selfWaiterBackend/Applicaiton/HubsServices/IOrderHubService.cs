using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.HubsServices
{
    public interface IOrderHubService
    {
        Task OrderAddedMessageAsync(string message);
    }
}
