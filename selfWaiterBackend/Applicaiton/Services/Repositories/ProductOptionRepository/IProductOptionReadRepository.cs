using Core.Persistence.Repositories;
using Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Services.Repositories.ProductOptionRepository
{
    public interface IProductOptionReadRepository: IReadRepository<ProductOption>
    {
    }
}
