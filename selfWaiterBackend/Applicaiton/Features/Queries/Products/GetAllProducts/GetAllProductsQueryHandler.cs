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
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, GetAllProductsQueryResponse>
    {

        private readonly IProductService _productService;

        public GetAllProductsQueryHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<GetAllProductsQueryResponse> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var (result, totalCount) = await _productService.GetAllProductsAsync(request.Size, request.Page);

            GetAllProductsQueryResponse response = new()
            {
                Products = result,
                TotalCount= totalCount,
            };

            //getProductDTOs.ForEach(p =>
            //{
            //    response.Add(new GetAllProductsQueryResponse
            //    {
            //        Id = p.Id,
            //        CategoryId = p.CategoryId,
            //        IsActive = p.IsActive,
            //        Price = p.Price,
            //        Translation = p.Translation,
            //        TotalCount = p.TotalCount,
            //    });
            //});

            return response;

        }
    }
}
