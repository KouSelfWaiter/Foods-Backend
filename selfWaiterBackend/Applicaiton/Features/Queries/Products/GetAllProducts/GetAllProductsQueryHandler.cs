using Applicaiton.DTOs.ProductDTO;
using Applicaiton.Services.ProductService;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Queries.Products.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, List<GetAllProductsQueryResponse>>
    {

        private readonly IProductService _productService;

        public GetAllProductsQueryHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<List<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            List<GetProductDTO> getProductDTOs = await _productService.GetAllProductsAsync(request.Size, request.Page);

            List<GetAllProductsQueryResponse> response = new List<GetAllProductsQueryResponse>();

            getProductDTOs.ForEach(p =>
            {
                response.Add(new GetAllProductsQueryResponse
                {
                    Id = p.Id,
                    CategoryId = p.CategoryId,
                    IsActive = p.IsActive,
                    Price = p.Price,
                    Translation = p.Translation,
                    TotalCount = p.TotalCount,
                });
            });

            return response;

        }
    }
}
