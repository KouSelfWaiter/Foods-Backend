using Core.Security.Dtos;
using SelfWaiterAuth.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Application.Features.Commands.Auth.CreateToken
{
    public class CreateTokenCommandResponse
    {
        public ResponseDto<TokenDto> ResponseDto { get; set; }
    }
}
