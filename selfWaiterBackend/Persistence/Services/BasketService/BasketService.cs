using Applicaiton.DTOs.BasketItemDTO;
using Applicaiton.DTOs.ProductDTO;
using Applicaiton.Services.BasketService;
using Applicaiton.Services.Repositories.BasketItemRepository;
using Applicaiton.Services.Repositories.BasketRepository;
using Applicaiton.Services.Repositories.OrderRepository;
using Applicaiton.Services.Repositories.ProductRepository;
using Domain.Entities.Baskets;
using Domain.Entities.Files;
using Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services.BasketService
{
    public class BasketService : IBasketService
    {
        private readonly IBasketReadRepository _basketReadRepository;
        private readonly IBasketWriteRepository _basketWriteRepository;
        private readonly IBasketItemReadRepository _basketItemReadRepository;
        private readonly IBasketItemWriteRepository _basketItemWriteRepository;
        private readonly IOrderReadRepository _orderReadRepository;
        private readonly IProductReadRepository _productReadRepository;

        public BasketService(IBasketReadRepository basketRepository, IBasketWriteRepository basketWriteRepository, IBasketItemReadRepository basketItemReadRepository, IBasketItemWriteRepository basketItemWriteRepository, IOrderReadRepository orderReadRepository, IProductReadRepository productReadRepository)
        {
            _basketReadRepository = basketRepository;
            _basketWriteRepository = basketWriteRepository;
            _basketItemReadRepository = basketItemReadRepository;
            _basketItemWriteRepository = basketItemWriteRepository;
            _orderReadRepository = orderReadRepository;
            _productReadRepository = productReadRepository;
        }


        public Basket GetTableActiveBasket => GetAvaliableBasket().Result;

        public async Task CreateBasketItemAsync(CreateBasketItemDTO createBasketItemDTO)
        {
            Basket basket = GetTableActiveBasket;
      
            if(basket != null) {

                // eklencek urunun aynisi mi eklenmeye calisiliyor kontrol edelim
                // not: newledik ya ordacn cekiyoz gettable belki hani id atamamis olabiilir onu kotnrol et belki
                BasketItem? basketItem = await _basketItemReadRepository.Table.Include(bi => bi.Basket).Include(bi => bi.Product)
                    .                                                         FirstOrDefaultAsync(bi => bi.Basket.Id == basket.Id && bi.Product.Id == Guid.Parse(createBasketItemDTO.ProductId));

                if(basketItem != null)
                {
                    basketItem.Quantity+= createBasketItemDTO.Quantity;
                }
                else
                {
                    //urun ilk defa eklenecektir
                    Product product = await _productReadRepository.GetByIdAsync(createBasketItemDTO.ProductId);
                    if (product == null)
                        throw new Exception("Urun Bulunamadi.  (CreateBasketItemAsync)");

                    await _basketItemWriteRepository.AddAsync(new BasketItem()
                    {
                        Basket = basket,
                        IsActive= true,
                        Product= product,
                        Quantity= createBasketItemDTO.Quantity,
                        
                    });
                }


                _ = await _basketItemReadRepository.SaveAsync();


            }
            else
            {
                throw new Exception("Basket Bulunamadi (CreateBasketItemAsync)");
            }
        }

        public async Task DeleteBasketItemAsync(string id)
        {
            BasketItem basketItem = await _basketItemReadRepository.GetByIdAsync(id);
            if (basketItem != null)
            {
                 _basketItemWriteRepository.Remove(basketItem);
                _ = await _basketItemWriteRepository.SaveAsync();
            }
        }

        public async Task<List<GetBasketItemDTO>> GetBasketItemsAsync()
        {
            Basket basket = GetTableActiveBasket;
            
            Basket?  resultBasket = await _basketReadRepository.Table.Include(b => b.BasketItems)
                                                                    .ThenInclude(bi => bi.Product)
                                                                    .ThenInclude(p => p.Translations)
                                                                    .FirstOrDefaultAsync(b => b.Id == basket.Id);

            List<GetBasketItemDTO> result = new List<GetBasketItemDTO>();
            string tableNo = resultBasket.TableNo;

            resultBasket.BasketItems.ToList().ForEach(bi => {

                List<GetProductTranslationDTO> getProductTranslationDTOs = new List<GetProductTranslationDTO>();

                //add product translation
                bi.Product.Translations.ForEach(pt =>
                {
                    getProductTranslationDTOs.Add(new()
                    {
                        Description= pt.Description,
                        Name=pt.Name,
                        TranslationCode =pt.TranslationCode,
                    });
                });


                result.Add(new()
                {
                    ProductTranslation = getProductTranslationDTOs,
                    Quantity = bi.Quantity,
                    TableNo = tableNo
                    
                });
            
            });

         
            return result;  
        }

        public async Task UpdateBasketItemAsync(UpdateBasketItemDTO updateBasketItemDTO)
        {
            BasketItem basketItem = await _basketItemReadRepository.GetByIdAsync(updateBasketItemDTO.BasketItemId);
            if(basketItem != null)
            {
                basketItem.Quantity= updateBasketItemDTO.Quantity;
                _ = await _basketItemReadRepository.SaveAsync();
            }
        }


        private async Task<Basket> GetAvaliableBasket()
        {
            // default olarak tabel no '1' kabul edilecektir

            Basket? activeBasket = await _basketReadRepository.Table
                                                              .FirstOrDefaultAsync(b => b.IsActive && b.TableNo.Equals("1"));      
            if(activeBasket == null)
            {
                // henuz sepete olusturulmamis
                activeBasket = new Basket()
                {
                    IsActive = true,
                    TableNo = "1",         
                };

                _ = await _basketWriteRepository.AddAsync(activeBasket);
                _ = await _basketWriteRepository.SaveAsync();

                return activeBasket;
            }

            return activeBasket;
            
        }


    }
}
