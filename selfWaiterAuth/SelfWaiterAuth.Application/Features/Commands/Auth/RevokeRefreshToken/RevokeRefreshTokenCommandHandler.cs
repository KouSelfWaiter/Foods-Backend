using MediatR;
using SelfWaiterAuth.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Application.Features.Commands.Auth.RevokeRefreshToken
{
    public class RevokeRefreshTokenCommandHandler : IRequestHandler<RevokeRefreshTokenCommandRequest, RevokeRefreshTokenCommandResponse>
    {
        private readonly IAuthenticationService _authenticationService;

        public RevokeRefreshTokenCommandHandler(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public async Task<RevokeRefreshTokenCommandResponse> Handle(RevokeRefreshTokenCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _authenticationService.RevokeRefreshToken(request.RefreshToken);

            return new()
            {
                ResponseDto = result,
            };
        }
    }
}
