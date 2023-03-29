using Applicaiton.Services.BasketService;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Baskets.UpdateBasketItem
{
    public class UpdateBasketItemCommandHandler : IRequestHandler<UpdateBasketItemCommandRequest, UpdateBasketItemCommandResponse>
    {
        private readonly IBasketService _basketService;

        public UpdateBasketItemCommandHandler(IBasketService basketService)
        {
            _basketService = basketService;
        }

        public async Task<UpdateBasketItemCommandResponse> Handle(UpdateBasketItemCommandRequest request, CancellationToken cancellationToken)
        {
            await _basketService.UpdateBasketItemAsync(new()
            {
                BasketItemId = request.BasketItemId,
                Quantity = request.Quantity,
            });

            return new();
        }
    }
}
