using Applicaiton.Services.Repositories.OrderRepository;
using Domain.Entities.Baskets;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.OrderRepository
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(SelfWaiterDbContext context) : base(context)
        {
        }
    }
}
