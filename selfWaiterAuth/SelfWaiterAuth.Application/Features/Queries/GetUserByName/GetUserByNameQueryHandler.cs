using MediatR;
using SelfWaiterAuth.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Application.Features.Queries.GetUserByName
{
    public class GetUserByNameQueryHandler : IRequestHandler<GetUserByNameQueryRequest, GetUserByNameQueryResponse>
    {
        private readonly IUserService _userService;

        public GetUserByNameQueryHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<GetUserByNameQueryResponse> Handle(GetUserByNameQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _userService.GetUserByUserName(request.UserName);

            return new()
            {
                ResponseDto = response
            };
        }
    }
}
