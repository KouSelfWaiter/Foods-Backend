using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Application.Features.Commands.User.CreateUserRole
{
    public class CreateUserRoleCommandRequest: IRequest<CreateUserRoleCommandResponse>
    {
        public string? UserName { get; set; } 
    }
}
