using Applicaiton.DTOs.ProductDTO;
using Applicaiton.Services.ProductService;
using Core.Applicaiton.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Products.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        private readonly IProductService _productService;

        public CreateProductCommandHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            CreateProductDTO createProductDTO = new CreateProductDTO()
            {
                CategoryId= request.CategoryId,
                Description= request.Description,
                IsActive= request.IsActive,
                Name= request.Name,
                Price= request.Price,
                TranslationCode = (TranslationCode) request.TranslationCode,
            };

            await _productService.CreateProductAsync(createProductDTO);

            return new();
        }
    }
}
