using Applicaiton.Features.Commands.Orders.CompleteOrder;
using Applicaiton.Features.Commands.Orders.CreateOrder;
using Applicaiton.Features.Queries.Orders.GetOrderById;
using Applicaiton.Features.Queries.Orders.GetOrders;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrders([FromQuery] GetOrdersQueryRequest getOrdersQueryRequest)
        {
            GetOrdersQueryResponse response = await _mediator.Send(getOrdersQueryRequest);

            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetOrderById([FromRoute]GetOrderByIdQueryRequest getOrderByIdQueryRequest)
        {
            GetOrderByIdQueryResponse response = await _mediator.Send(getOrderByIdQueryRequest);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(CreateOrderCommandRequest createOrderCommandRequest)
        {
            CreateOrderCommandResponse response = await _mediator.Send(createOrderCommandRequest);

            return Ok(response);
        }

        [HttpPost("{Id}")]
        [Authorize]
        public async Task<IActionResult> CompleteOrder([FromRoute]CompleteOrderCommandRequest completeOrderCommandRequest)
        {
            CompleteOrderCommandResponse response = await _mediator.Send(completeOrderCommandRequest);

            return Ok(response);
        }
    }
}
