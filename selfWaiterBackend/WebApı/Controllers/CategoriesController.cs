using Applicaiton.Features.Commands.Categories.CreateCategory;
using Applicaiton.Features.Commands.Categories.CreateCategoryTranslation;
using Applicaiton.Features.Commands.Categories.DeleteCategory;
using Applicaiton.Features.Commands.Categories.UpdateCategory;
using Applicaiton.Features.Commands.Categories.UpdateCategoryTranslation;
using Applicaiton.Features.Queries.Categories.GetAllCategories;
using Applicaiton.Features.Queries.Categories.GetCategoryById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories([FromQuery]GetAllCategoriesQueryRequest getAllCategoriesQueryRequest)
        {
            List<GetAllCategoriesQueryResponse> response = await _mediator.Send(getAllCategoriesQueryRequest);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetCategoryById([FromRoute]GetCategoryByIdQueryRequest getCategoryByIdQueryRequest)
        {
            GetCategoryByIdQueryResponse response = await _mediator.Send(getCategoryByIdQueryRequest);

            return Ok(response);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateCategory(CreateCategoryCommandRequest createCategoryCommandRequest)
        {
            CreateCategoryCommandResponse response = await _mediator.Send(createCategoryCommandRequest);

            return Ok(response);
        }
        [HttpPost("[action]")]
        [Authorize]
        public async Task<IActionResult> CreateCategoryTranslation(CreateCategoryTranslationCommandRequest createCategoryTranslationCommandRequest)
        {
            CreateCategoryTranslationCommandResponse response = await _mediator.Send(createCategoryTranslationCommandRequest);

            return Ok(response);
        }

        [HttpDelete("{Id}")]
        [Authorize]
        public async Task<IActionResult> DeleteCategory([FromRoute] DeleteCategoryCommandRequest deleteCategoryCommandRequest)
        {
            DeleteCategoryCommandResponse response = await _mediator.Send(deleteCategoryCommandRequest);

            return Ok(response);
        }

        [HttpPut]
        [Authorize]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryCommandRequest updateCategoryCommandRequest)
        {
            UpdateCategoryCommandResponse response = await _mediator.Send(updateCategoryCommandRequest);

            return Ok(response);
        }

        [HttpPut("[action]")]
        [Authorize]
        public async Task<IActionResult> UpdateCategoryTranslation(UpdateCategoryTranslationCommandRequest updateCategoryTranslationCommandRequest)
        {
            UpdateCategoryTranslationCommandResponse response = await _mediator.Send(updateCategoryTranslationCommandRequest);

            return Ok(response);
        }
    }
}
