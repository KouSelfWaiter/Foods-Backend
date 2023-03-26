using Applicaiton.DTOs.CategoryDTO;
using Applicaiton.Services.CategoryService;
using Core.Applicaiton.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Categories.UpdateCategory
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommandRequest, UpdateCategoryCommandResponse>
    {
        private readonly ICategoryService _categoryService;

        public UpdateCategoryCommandHandler(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<UpdateCategoryCommandResponse> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            UpdateCategoryDTO updateCategoryDTO = new UpdateCategoryDTO
            {
                Id = request.Id,
                IsActive= request.IsActive,
                IsDeleted= request.IsDeleted,
                Name= request.Name,
                TranslationCode = (TranslationCode)request.TranslationCode,
            };

            await _categoryService.UpdateCategoryAsync(updateCategoryDTO);

            return new();

        }
    }
}
