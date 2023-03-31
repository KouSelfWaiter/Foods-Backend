using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Orders.CompleteOrder
{
    public class CompleteOrderCommandRequest: IRequest<CompleteOrderCommandResponse>
    {
        public string Id { get; set; }
    }
}
