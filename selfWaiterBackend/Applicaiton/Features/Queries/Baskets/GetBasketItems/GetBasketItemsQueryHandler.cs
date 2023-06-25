using Applicaiton.DTOs.BasketItemDTO;
using Applicaiton.Services.BasketService;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Queries.Baskets.GetBasketItems
{
    public class GetBasketItemsQueryHandler : IRequestHandler<GetBasketItemsQueryRequest, GetBasketItemsQueryResponse>
    {
        private readonly IBasketService _basketService;

        public GetBasketItemsQueryHandler(IBasketService basketService)
        {
            _basketService = basketService;
        }

        public async Task<GetBasketItemsQueryResponse> Handle(GetBasketItemsQueryRequest request, CancellationToken cancellationToken)
        {
            var (result, tableNo, basketId) = await _basketService.GetBasketItemsAsync();
            
            return new()
            {
                GetBasketItemDTOs= result,
                TableNo = tableNo,
                BasketId = basketId
            };
        }
    }
}
