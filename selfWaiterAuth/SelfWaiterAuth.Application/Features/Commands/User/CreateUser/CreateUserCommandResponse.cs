using Core.Security.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Application.Features.Commands.User.CreateUser
{
    public class CreateUserCommandResponse
    {
        public ResponseDto<BlankDto> ResponseDto  { get; set; }
    }
}
