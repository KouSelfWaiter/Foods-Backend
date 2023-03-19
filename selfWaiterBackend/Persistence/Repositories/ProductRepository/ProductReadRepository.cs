using Applicaiton.Services.Repositories.ProductRepository;
using Domain.Entities.Products;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.ProductRepository
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(SelfWaiterDbContext context) : base(context)
        {
        }
    }
}
