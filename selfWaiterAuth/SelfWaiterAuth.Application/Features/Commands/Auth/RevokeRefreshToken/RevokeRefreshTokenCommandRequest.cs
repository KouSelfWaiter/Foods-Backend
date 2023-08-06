using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Application.Features.Commands.Auth.RevokeRefreshToken
{
    public class RevokeRefreshTokenCommandRequest: IRequest<RevokeRefreshTokenCommandResponse>
    {
        public string RefreshToken { get; set; }
    }
}
