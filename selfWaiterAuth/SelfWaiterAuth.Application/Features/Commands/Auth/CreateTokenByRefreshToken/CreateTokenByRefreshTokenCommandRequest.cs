using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Application.Features.Commands.Auth.CreateTokenByRefreshToken
{
    public class CreateTokenByRefreshTokenCommandRequest: IRequest<CreateTokenByRefreshTokenCommandResponse>
    {
        public string RefreshToken { get; set; }
    }
}
