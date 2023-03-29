using Applicaiton.Features.Commands.Baskets.CreateBasketItem;
using Applicaiton.Features.Commands.Baskets.DeleteBasketItem;
using Applicaiton.Features.Commands.Baskets.UpdateBasketItem;
using Applicaiton.Features.Queries.Baskets.GetBasketItems;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BasketsController(IMediator mediator)
        {
            _mediator = mediator;
        }



        [HttpGet]
        public async Task<IActionResult> GetBasketItems([FromQuery]GetBasketItemsQueryRequest getBasketItemsQueryRequest)
        {
            List<GetBasketItemsQueryResponse> response = await _mediator.Send(getBasketItemsQueryRequest);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBasketItem(CreateBasketItemCommandRequest createBasketItemCommandRequest)
        {
            CreateBasketItemCommandResponse response = await _mediator.Send(createBasketItemCommandRequest);

            return Ok(response);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteBasketItem([FromRoute]DeleteBasketItemCommandRequest deleteBasketItemCommandRequest)
        {
            DeleteBasketItemCommandResponse response = await _mediator.Send(deleteBasketItemCommandRequest);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBasketItem(UpdateBasketItemCommandRequest updateBasketItemCommandRequest)
        {
            UpdateBasketItemCommandResponse response = await _mediator.Send(updateBasketItemCommandRequest);

            return Ok(response);
        }

        

       
    }
}
