﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Queries.Categories.GetAllCategories
{
    public class GetAllCategoriesQueryRequest: IRequest<GetAllCategoriesQueryResponse>
    {
    }
}
