using MediatR;
using SelfWaiterAuth.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Application.Features.Commands.Auth.CreateToken
{
    public class CreateTokenCommandHandler : IRequestHandler<CreateTokenCommandRequest, CreateTokenCommandResponse>
    {
        private readonly IAuthenticationService _authenticationService;

        public CreateTokenCommandHandler(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public async Task<CreateTokenCommandResponse> Handle(CreateTokenCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _authenticationService.CreateTokenAsync(new() { Email = request.Email, Password = request.Password });

            return new()
            {
                ResponseDto = result,
            };
        }
    }
}
