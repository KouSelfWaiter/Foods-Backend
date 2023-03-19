using Applicaiton.Services.Repositories.CategoryRepository;
using Domain.Entities.Products;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.CategoryRepository
{
    public class CategoryReadRepository : ReadRepository<Category>, ICategoryReadRepository
    {
        public CategoryReadRepository(SelfWaiterDbContext context) : base(context)
        {
        }
    }
}
