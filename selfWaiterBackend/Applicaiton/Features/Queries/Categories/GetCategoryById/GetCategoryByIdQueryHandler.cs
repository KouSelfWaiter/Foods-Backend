using Applicaiton.DTOs.CategoryDTO;
using Applicaiton.Services.CategoryService;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Queries.Categories.GetCategoryById
{
    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQueryRequest, GetCategoryByIdQueryResponse>
    {
        private readonly ICategoryService _categoryService;

        public GetCategoryByIdQueryHandler(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<GetCategoryByIdQueryResponse> Handle(GetCategoryByIdQueryRequest request, CancellationToken cancellationToken)
        {
            GetCategoryDTO getCategoryDTO = await _categoryService.GetCategoryByIdAsync(request.Id);

            return new()
            {
                Id = getCategoryDTO.Id,
                IsActive = getCategoryDTO.IsActive,
                Translations = getCategoryDTO.Translations,
            };
        }
    }
}
