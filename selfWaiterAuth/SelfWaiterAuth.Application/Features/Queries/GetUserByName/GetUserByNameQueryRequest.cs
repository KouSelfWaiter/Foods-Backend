using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Application.Features.Queries.GetUserByName
{
    public class GetUserByNameQueryRequest: IRequest<GetUserByNameQueryResponse>
    {
        public string? UserName { get; set; }
    }
}
