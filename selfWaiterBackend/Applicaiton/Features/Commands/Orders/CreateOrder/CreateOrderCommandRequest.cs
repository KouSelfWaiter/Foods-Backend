using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Orders.CreateOrder
{
    public class CreateOrderCommandRequest: IRequest<CreateOrderCommandResponse>
    {
        public string? Note { get; set; }
        public string BasketId { get; set; }
    }
}
