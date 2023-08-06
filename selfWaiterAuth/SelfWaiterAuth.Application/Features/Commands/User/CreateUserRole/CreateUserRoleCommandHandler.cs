using MediatR;
using SelfWaiterAuth.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Application.Features.Commands.User.CreateUserRole
{
    public class CreateUserRoleCommandHandler : IRequestHandler<CreateUserRoleCommandRequest, CreateUserRoleCommandResponse>
    {
        private readonly IUserService _userService;

        public CreateUserRoleCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<CreateUserRoleCommandResponse> Handle(CreateUserRoleCommandRequest request, CancellationToken cancellationToken)
        {
            var response = await _userService.CreateUserRolesAsync(request.UserName);

            return new()
            {
                ResponseDto = response,
            };
        }
    }
}
