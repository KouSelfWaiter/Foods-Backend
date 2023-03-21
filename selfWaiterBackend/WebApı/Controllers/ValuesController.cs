using Applicaiton.Services.Repositories.CategoryRepository;
using Applicaiton.Services.Repositories.ProductRepository;
using Domain.Entities.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly ICategoryWriteRepository _categoryWriteRepository;

        public ValuesController(IProductWriteRepository productWriteRepository, ICategoryWriteRepository categoryWriteRepository)
        {
            _productWriteRepository = productWriteRepository;
            _categoryWriteRepository = categoryWriteRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            Category category = new Category { Id = Guid.NewGuid(), IsActive = true, IsDeleted = false,  };

            _ = await _categoryWriteRepository.AddAsync(category);

            _ = await _categoryWriteRepository.SaveAsync();

            return Ok();
        }
    }
}
