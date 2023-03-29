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
    public class GetBasketItemsQueryHandler : IRequestHandler<GetBasketItemsQueryRequest, List<GetBasketItemsQueryResponse>>
    {
        private readonly IBasketService _basketService;

        public GetBasketItemsQueryHandler(IBasketService basketService)
        {
            _basketService = basketService;
        }

        public async Task<List<GetBasketItemsQueryResponse>> Handle(GetBasketItemsQueryRequest request, CancellationToken cancellationToken)
        {
            List<GetBasketItemDTO> getBasketItemDTOs = await _basketService.GetBasketItemsAsync();
            List<GetBasketItemsQueryResponse> response = new List<GetBasketItemsQueryResponse>();

            getBasketItemDTOs.ForEach(bi =>
            {
                response.Add(new GetBasketItemsQueryResponse()
                {
                    ProductTranslation = bi.ProductTranslation,
                    Quantity = bi.Quantity,
                    TableNo = bi.TableNo,
                });
            });

            return response;
        }
    }
}
