using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelfWaiterAuth.Application.Dtos;
using SelfWaiterAuth.Application.Features.Commands.User.CreateUser;
using SelfWaiterAuth.Application.Features.Commands.User.CreateUserRole;
using SelfWaiterAuth.Application.Features.Queries.GetUserByName;

namespace SelfWaiterAuth.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetUserByName([FromQuery] GetUserByNameQueryRequest request)
        {
            request.UserName = User.Identity.Name;

            var response = await _mediator.Send(request);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommandRequest request)
        {
            var response = await _mediator.Send(request);

            return Ok(response);
        }

        [HttpPost("[action]")]
        [Authorize]
        public async Task<IActionResult> CreateUserRoles([FromQuery] CreateUserRoleCommandRequest request)
        {
            request.UserName = User.Identity.Name;

            var response = await _mediator.Send(request);

            return Ok(response);
        }

    }
}
