using Applicaiton.Services.Repositories.ProductOptionRepository;
using Domain.Entities.Products;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.ProductOptionRepository
{
    public class ProductOptionReadRepository : ReadRepository<ProductOption>, IProductOptionReadRepository
    {
        public ProductOptionReadRepository(SelfWaiterDbContext context) : base(context)
        {
        }
    }
}
