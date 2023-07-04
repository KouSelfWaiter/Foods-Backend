using Applicaiton.Services.BasketService;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Baskets.DeleteBasketItem
{
    public class DeleteBasketItemCommandHandler : IRequestHandler<DeleteBasketItemCommandRequest, DeleteBasketItemCommandResponse>
    {
        private readonly IBasketService _basketService;

        public DeleteBasketItemCommandHandler(IBasketService basketService)
        {
            _basketService = basketService;
        }

        public async Task<DeleteBasketItemCommandResponse> Handle(DeleteBasketItemCommandRequest request, CancellationToken cancellationToken)
        {
            decimal totalPrice = await _basketService.DeleteBasketItemAsync(request.Id);

            return new DeleteBasketItemCommandResponse() { TotalPrice = totalPrice};
        }
    }
}
