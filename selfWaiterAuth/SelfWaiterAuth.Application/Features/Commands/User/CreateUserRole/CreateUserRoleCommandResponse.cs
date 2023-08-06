using Core.Security.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Application.Features.Commands.User.CreateUserRole
{
    public class CreateUserRoleCommandResponse
    {
        public ResponseDto<BlankDto> ResponseDto { get; set; }  
    }
}
