using Applicaiton.DTOs.CategoryDTO;
using Applicaiton.Services.CategoryService;
using Core.Applicaiton.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Categories.CreateCategory
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest, CreateCategoryCommandResponse>
    {
        private readonly ICategoryService _categoryService;

        public CreateCategoryCommandHandler(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<CreateCategoryCommandResponse> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            CreateCategoryDTO categoryDTO = new CreateCategoryDTO()
            {
                Name = request.Name,
                IsActive = request.IsActive,
            };

            if (request.TranslationCode == 0)
                categoryDTO.TranslationCode = TranslationCode.tr_TR;
            else
                categoryDTO.TranslationCode = TranslationCode.en_EN;

            await _categoryService.CreateCategoryAsync(categoryDTO);

            return new();
        }
    }
}
