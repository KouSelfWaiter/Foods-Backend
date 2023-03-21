using Applicaiton.Services.Repositories.BasketRepository;
using Domain.Entities.Baskets;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.BasketRepository
{
    public class BasketReadRepository : ReadRepository<Basket>, IBasketReadRepository
    {
        public BasketReadRepository(SelfWaiterDbContext context) : base(context)
        {
        }
    }
}
