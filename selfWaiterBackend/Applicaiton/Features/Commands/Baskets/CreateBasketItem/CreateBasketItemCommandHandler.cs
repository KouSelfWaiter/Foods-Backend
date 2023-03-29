using Applicaiton.DTOs.BasketItemDTO;
using Applicaiton.Services.BasketService;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Baskets.CreateBasketItem
{
    public class CreateBasketItemCommandHandler : IRequestHandler<CreateBasketItemCommandRequest, CreateBasketItemCommandResponse>
    {
        private readonly IBasketService _basketService;

        public CreateBasketItemCommandHandler(IBasketService basketService)
        {
            _basketService = basketService;
        }

        public async Task<CreateBasketItemCommandResponse> Handle(CreateBasketItemCommandRequest request, CancellationToken cancellationToken)
        {
            CreateBasketItemDTO createBasketItemDTO = new CreateBasketItemDTO()
            {
                ProductId= request.ProductId,
                Quantity = request.Quantity,
            };

            await _basketService.CreateBasketItemAsync(createBasketItemDTO);

            return new();
        }
    }
}
