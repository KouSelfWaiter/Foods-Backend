using Applicaiton.Services.BasketService;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Queries.Baskets.GetActiveBasketId
{
    public class GetActiveBasketIdQueryHandler : IRequestHandler<GetActiveBasketIdQueryRequest, GetActiveBasketIdQueryResponse>
    {
        private readonly IBasketService _basketService;

        public GetActiveBasketIdQueryHandler(IBasketService basketService)
        {
            _basketService = basketService;
        }

        public Task<GetActiveBasketIdQueryResponse> Handle(GetActiveBasketIdQueryRequest request, CancellationToken cancellationToken)
        {
            string basketId  =  _basketService.GetTableActiveBasketId();

            return Task.FromResult(new GetActiveBasketIdQueryResponse()
            {
                Id = basketId,
            });
        }
    }
}
