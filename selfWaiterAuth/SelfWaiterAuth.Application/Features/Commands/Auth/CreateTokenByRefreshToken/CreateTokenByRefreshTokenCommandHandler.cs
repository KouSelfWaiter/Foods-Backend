using MediatR;
using SelfWaiterAuth.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Application.Features.Commands.Auth.CreateTokenByRefreshToken
{
    public class CreateTokenByRefreshTokenCommandHandler : IRequestHandler<CreateTokenByRefreshTokenCommandRequest, CreateTokenByRefreshTokenCommandResponse>
    {
        private readonly IAuthenticationService _authenticationService;

        public CreateTokenByRefreshTokenCommandHandler(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public async Task<CreateTokenByRefreshTokenCommandResponse> Handle(CreateTokenByRefreshTokenCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _authenticationService.CreateTokenByRefreshToken(request.RefreshToken);

            return new()
            {
                ResponseDto = result,
            };
        }
    }
}
