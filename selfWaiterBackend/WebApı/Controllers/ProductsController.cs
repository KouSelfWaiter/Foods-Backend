using Applicaiton.Features.Commands.Products.CreateProduct;
using Applicaiton.Features.Commands.Products.CreateProductTranslation;
using Applicaiton.Features.Commands.Products.DeleteProduct;
using Applicaiton.Features.Commands.Products.UpdateProduct;
using Applicaiton.Features.Commands.Products.UpdateProductTranslation;
using Applicaiton.Features.Queries.Products.GetAllProducts;
using Applicaiton.Features.Queries.Products.GetProductById;
using Applicaiton.Features.Queries.Products.GetProductImages;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts([FromQuery]GetAllProductsQueryRequest getAllProductsQueryRequest)
        {
            List<GetAllProductsQueryResponse> response = await _mediator.Send(getAllProductsQueryRequest);

            return Ok(response);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetProductById([FromRoute]GetProductByIdQueryRequest getProductByIdQueryRequest)
        {
            GetProductByIdQueryResponse response = await _mediator.Send(getProductByIdQueryRequest);

            return Ok(response);
        }

        [HttpGet("[action]/{ProductId}")]
        public async Task<IActionResult> GetProductImages([FromRoute]GetProductImagesQueryRequest getProductImagesQueryRequest)
        {
            GetProductImagesQueryResponse response = await _mediator.Send(getProductImagesQueryRequest);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommandRequest createProductCommandRequest)
        {
            CreateProductCommandResponse response = await _mediator.Send(createProductCommandRequest);

            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateProductTranslation(CreateProductTranslationCommandRequest createProductTranslationCommandRequest)
        {
            CreateProductTranslationCommandResponse response = await _mediator.Send(createProductTranslationCommandRequest);
            
            return Ok(response);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] DeleteProductCommandRequest deleteProductCommandRequest)
        {
            DeleteProductCommandResponse response = await _mediator.Send(deleteProductCommandRequest);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommandRequest updateProductCommandRequest)
        {
            UpdateProductCommandResponse response = await _mediator.Send(updateProductCommandRequest);

            return Ok(response);
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateProductTranslation(UpdateProductTranslationCommandRequest updateProductTranslationCommandRequest)
        {
            UpdateProductTranslationCommandResponse response = await _mediator.Send(updateProductTranslationCommandRequest);

            return Ok(response);
        }
    }
}
