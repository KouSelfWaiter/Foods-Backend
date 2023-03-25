using Applicaiton.DTOs.ProductDTO;
using Applicaiton.Services.ProductService;
using Core.Applicaiton.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Products.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest, UpdateProductCommandResponse>
    {
        private readonly IProductService _productService;

        public UpdateProductCommandHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<UpdateProductCommandResponse> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            UpdateProductDTO updateProductDTO = new UpdateProductDTO()
            {
                Description= request.Description,
                Id= request.Id,
                IsActive= request.IsActive,
                Name= request.Name,
                Price = request.Price
            };

            if (request.TranslationCode == 0)
                updateProductDTO.TranslationCode = TranslationCode.tr_TR;
            else
                updateProductDTO.TranslationCode = TranslationCode.en_EN;

            await _productService.UpdateProductAsync(updateProductDTO);

            return new UpdateProductCommandResponse();

        }
    }
}
