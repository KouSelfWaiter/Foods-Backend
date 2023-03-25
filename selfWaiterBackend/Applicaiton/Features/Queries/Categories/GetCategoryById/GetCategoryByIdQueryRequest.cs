using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Queries.Categories.GetCategoryById
{
    public class GetCategoryByIdQueryRequest: IRequest<GetCategoryByIdQueryResponse>
    {
        public string Id { get; set; }
    }
}
