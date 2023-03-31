using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Queries.Products.GetProductImages
{
    public class GetProductImagesQueryRequest: IRequest<GetProductImagesQueryResponse>
    {
        public string ProductId { get; set; }
    }
}
