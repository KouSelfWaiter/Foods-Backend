using Applicaiton.Services.Repositories.BasketItemRepository;
using Domain.Entities.Baskets;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.BasketItemRepository
{
    public class BasketItemWriteRepository : WriteRepository<BasketItem>, IBasketItemWriteRepository
    {
        public BasketItemWriteRepository(SelfWaiterDbContext context) : base(context)
        {
        }
    }
}
