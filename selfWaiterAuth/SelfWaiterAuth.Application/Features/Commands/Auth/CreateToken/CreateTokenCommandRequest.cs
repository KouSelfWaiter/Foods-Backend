using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Application.Features.Commands.Auth.CreateToken
{
    public class CreateTokenCommandRequest : IRequest<CreateTokenCommandResponse>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
