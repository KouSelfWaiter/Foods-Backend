using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Baskets.CreateBasketItem
{
    public class CreateBasketItemCommandRequest: IRequest<CreateBasketItemCommandResponse>
    {
        public int Quantity { get; set; }
        public string ProductId { get; set; }
    }
}
