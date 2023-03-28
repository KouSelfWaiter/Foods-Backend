using Applicaiton.DTOs.ProductDTO;
using Applicaiton.Services.ProductService;
using Core.Applicaiton.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Products.CreateProductTranslation
{
    public class CreateProductTranslationCommandHandler : IRequestHandler<CreateProductTranslationCommandRequest, CreateProductTranslationCommandResponse>
    {
        private readonly IProductService _productService;

        public CreateProductTranslationCommandHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<CreateProductTranslationCommandResponse> Handle(CreateProductTranslationCommandRequest request, CancellationToken cancellationToken)
        {
            CreateProductTranslationDTO createProductTranslationDTO = new CreateProductTranslationDTO()
            {
                Description= request.Description,
                Name= request.Name,
                ProductId= request.ProductId,
                TranslationCode = (TranslationCode)request.TranslationCode,
            };

            await _productService.CreateProductTranslationAsync(createProductTranslationDTO);

            return new();

        }
    }
}
