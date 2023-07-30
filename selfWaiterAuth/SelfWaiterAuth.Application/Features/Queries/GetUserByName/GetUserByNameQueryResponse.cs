using Core.Security.Dtos;
using SelfWaiterAuth.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Application.Features.Queries.GetUserByName
{
    public class GetUserByNameQueryResponse
    {
        public ResponseDto<UserAppDto> ResponseDto { get; set; }
    }
}
