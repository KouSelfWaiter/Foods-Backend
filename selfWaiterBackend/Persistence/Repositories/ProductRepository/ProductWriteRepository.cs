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
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(SelfWaiterDbContext context) : base(context)
        {
        }
    }
}
