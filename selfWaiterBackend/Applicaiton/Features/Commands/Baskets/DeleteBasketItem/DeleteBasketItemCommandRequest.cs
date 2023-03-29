using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Baskets.DeleteBasketItem
{
    public class DeleteBasketItemCommandRequest: IRequest<DeleteBasketItemCommandResponse>
    {
        public string Id { get; set; }
    }
}
