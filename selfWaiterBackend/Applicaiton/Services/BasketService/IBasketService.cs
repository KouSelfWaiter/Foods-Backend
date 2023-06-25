using Applicaiton.DTOs.BasketItemDTO;
using Domain.Entities.Baskets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Services.BasketService
{
    public interface IBasketService
    {
        Task<(List<GetBasketItemDTO>, string tableNo, string basketId)> GetBasketItemsAsync();
        Task CreateBasketItemAsync(CreateBasketItemDTO createBasketItemDTO);
        Task UpdateBasketItemAsync(UpdateBasketItemDTO updateBasketItemDTO);
        Task DeleteBasketItemAsync(string id);
        string GetTableActiveBasketId();
        Basket GetTableActiveBasket { get; }

    }
}
