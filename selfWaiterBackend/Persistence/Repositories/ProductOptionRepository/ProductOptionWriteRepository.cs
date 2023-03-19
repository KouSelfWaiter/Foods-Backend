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
    public class ProductOptionWriteRepository : WriteRepository<ProductOption>, IProductOptionWriteRepository
    {
        public ProductOptionWriteRepository(SelfWaiterDbContext context) : base(context)
        {
        }
    }
}
