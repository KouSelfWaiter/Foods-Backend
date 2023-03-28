using Applicaiton.DTOs.CategoryDTO;
using Applicaiton.Services.CategoryService;
using Core.Applicaiton.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Categories.CreateCategoryTranslation
{
    public class CreateCategoryTranslationCommandHandler : IRequestHandler<CreateCategoryTranslationCommandRequest, CreateCategoryTranslationCommandResponse>
    {
        private readonly ICategoryService _categoryService;

        public CreateCategoryTranslationCommandHandler(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<CreateCategoryTranslationCommandResponse> Handle(CreateCategoryTranslationCommandRequest request, CancellationToken cancellationToken)
        {
            CreateCategoryTranslationDTO createCategoryTranslationDTO = new CreateCategoryTranslationDTO()
            {
                CategoryId= request.CategoryId,
                Name= request.Name,
                TranslationCode = (TranslationCode)request.TranslationCode,
            };

            await _categoryService.CreateCategoryTranslationAsync(createCategoryTranslationDTO);

            return new();
        }
    }
}
