using Applicaiton.DTOs.CategoryDTO;
using Applicaiton.Services.CategoryService;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Queries.Categories.GetAllCategories
{
    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQueryRequest, List<GetAllCategoriesQueryResponse>>
    {
        private readonly ICategoryService _categoryService;

        public GetAllCategoriesQueryHandler(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<List<GetAllCategoriesQueryResponse>> Handle(GetAllCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            List<GetAllCategoriesQueryResponse> response = new List<GetAllCategoriesQueryResponse>();

            List<GetCategoryDTO> getCategoryDTOs =await _categoryService.GetAllCategoriesAsync();

            getCategoryDTOs.ForEach(c =>
            {
                response.Add(new GetAllCategoriesQueryResponse { Id = c.Id, IsActive= c.IsActive, Translations = c.Translations });
            });

            return response;

        }
    }
}
