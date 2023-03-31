using Applicaiton.DTOs.ProductDTO;
using Applicaiton.Services.ProductService;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Queries.Products.GetProductImages
{
    public class GetProductImagesQueryHandler : IRequestHandler<GetProductImagesQueryRequest, GetProductImagesQueryResponse>
    {
        private readonly IProductService _productService;

        public GetProductImagesQueryHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<GetProductImagesQueryResponse> Handle(GetProductImagesQueryRequest request, CancellationToken cancellationToken)
        {
            GetProductImageDTO getProductImageDTO = await _productService.GetProductImagesAsync(request.ProductId);

            return new()
            {
                ProductId = getProductImageDTO.ProductId,
                ProductImageDTOs = getProductImageDTO.ProductImageDTOs
            };
        }
    }
}
