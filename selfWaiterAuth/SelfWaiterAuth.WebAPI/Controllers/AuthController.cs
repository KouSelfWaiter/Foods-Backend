using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelfWaiterAuth.Application.Dtos;
using SelfWaiterAuth.Application.Features.Commands.Auth.CreateToken;
using SelfWaiterAuth.Application.Features.Commands.Auth.CreateTokenByRefreshToken;
using SelfWaiterAuth.Application.Features.Commands.Auth.RevokeRefreshToken;

namespace SelfWaiterAuth.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        public async Task<IActionResult> CreateToken(CreateTokenCommandRequest request)
        {
            var result = await _mediator.Send(request);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> RevokeRefreshToken(RevokeRefreshTokenCommandRequest request)
        {
            var result = await _mediator.Send(request);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTokenByRefreshToken(CreateTokenByRefreshTokenCommandRequest request)
        {
            var result = await _mediator.Send(request);

            return Ok(result);
        }
    }
}
