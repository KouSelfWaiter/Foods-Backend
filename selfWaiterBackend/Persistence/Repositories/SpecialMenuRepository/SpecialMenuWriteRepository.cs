using Applicaiton.Services.Repositories.SpecialMenuRepository;
using Domain.Entities.Products;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.SpecialMenuRepository
{
    public class SpecialMenuWriteRepository : WriteRepository<SpecialMenu>, ISpecialMenuWriteRepository
    {
        public SpecialMenuWriteRepository(SelfWaiterDbContext context) : base(context)
        {
        }
    }
}
