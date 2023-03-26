using Applicaiton.DTOs.CategoryDTO;
using Applicaiton.Services.CategoryService;
using Core.Applicaiton.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Categories.UpdateCategoryTranslation
{
    public class UpdateCategoryTranslationCommandHandler : IRequestHandler<UpdateCategoryTranslationCommandRequest, UpdateCategoryTranslationCommandResponse>
    {
        private readonly ICategoryService _categoryService;

        public UpdateCategoryTranslationCommandHandler(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<UpdateCategoryTranslationCommandResponse> Handle(UpdateCategoryTranslationCommandRequest request, CancellationToken cancellationToken)
        {
            CreateCategoryTranslationDTO createCategoryTranslationDTO = new CreateCategoryTranslationDTO()
            {
                CategoryId = request.CategoryId,
                Name = request.Name,
                TranslationCode = (TranslationCode)request.TranslationCode,
            };

            await _categoryService.UpdateCategoryTranslationAsync(createCategoryTranslationDTO);

            return new();
        }
    }
}
