using Applicaiton.DTOs.ProductDTO;
using Applicaiton.Services.ProductService;
using Core.Applicaiton.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Products.UpdateProductTranslation
{
    public class UpdateProductTranslationCommandHandler : IRequestHandler<UpdateProductTranslationCommandRequest, UpdateProductTranslationCommandResponse>
    {
        private readonly IProductService _productService;

        public UpdateProductTranslationCommandHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<UpdateProductTranslationCommandResponse> Handle(UpdateProductTranslationCommandRequest request, CancellationToken cancellationToken)
        {
            CreateProductTranslationDTO createProductTranslationDTO = new CreateProductTranslationDTO()
            {
                Description= request.Description,
                Name= request.Name,
                ProductId= request.ProductId,
                TranslationCode = (TranslationCode) request.TranslationCode,
            };

            await _productService.UpdateProductTranslationAsync(createProductTranslationDTO);

            return new();
        }
    }
}
