using Core.Persistence.Repositories;
using Domain.Entities.Baskets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Services.Repositories.BasketItemRepository
{
    public interface IBasketItemWriteRepository: IWriteRepository<BasketItem>
    {
    }
}
