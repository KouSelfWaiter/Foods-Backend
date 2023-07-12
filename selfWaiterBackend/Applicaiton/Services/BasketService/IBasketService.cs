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
        Task<(List<GetBasketItemDTO>, string tableNo, string basketId, decimal totalPrice)> GetBasketItemsAsync();
        Task CreateBasketItemAsync(CreateBasketItemDTO createBasketItemDTO);
        Task<decimal> UpdateBasketItemAsync(UpdateBasketItemDTO updateBasketItemDTO);
        Task<decimal> DeleteBasketItemAsync(string id);
        string GetTableActiveBasketId();
        Basket GetTableActiveBasket { get; }

    }
}
