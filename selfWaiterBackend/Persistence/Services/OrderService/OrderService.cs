using Applicaiton.DTOs.BasketItemDTO;
using Applicaiton.DTOs.FileDTO;
using Applicaiton.DTOs.OrderDTO;
using Applicaiton.DTOs.ProductDTO;
using Applicaiton.Exceptions;
using Applicaiton.Services.OrderService;
using Applicaiton.Services.Repositories.BasketRepository;
using Applicaiton.Services.Repositories.OrderRepository;
using Domain.Entities.Baskets;
using Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly IOrderReadRepository _orderReadRepository;
        private readonly IOrderWriteRepository _orderWriteRepository;
        private readonly IBasketReadRepository _basketReadRepository;

        public OrderService(IOrderReadRepository orderReadRepository, IOrderWriteRepository orderWriteRepository, IBasketReadRepository basketReadRepository)
        {
            _orderReadRepository = orderReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _basketReadRepository = basketReadRepository;
        }

        public async Task CompleteOrder(string orderId)
        {
            Order order = await _orderReadRepository.GetByIdAsync(orderId);
            if (order == null)
                throw new OrderNotFoundException();
            order.IsCompleted = true;
            order.IsActive = false;

            _ = await _orderReadRepository.SaveAsync();
        }

        public async Task CreateOrderAsync(CreateOrderDTO createOrderDTO)
        {
            Basket basket = await _basketReadRepository.GetByIdAsync(createOrderDTO.BasketId);
            if (basket == null)
                throw new BasketNotFoundException();


            string orderCode = (new Random().NextDouble() * 10000).ToString();
            orderCode = orderCode.Substring(orderCode.IndexOf(",") + 1, orderCode.Length - orderCode.IndexOf(",") - 1);

            //artik bu basket ordera donusuyor islemler aliniyor
            basket.IsActive = false;

            Order order = new Order()
            {
                Basket = basket,
                IsActive = true,
                Note = createOrderDTO.Note,
                OrderCode = orderCode,
            };

            _ = await _orderWriteRepository.AddAsync(order);
            // bu islem basket' deki aktifligi de kaydeder
            _ = await _orderWriteRepository.SaveAsync();
        }

        public async Task<GetOrderDTO> GetOrderById(string orderId)
        {
            Order? order = await _orderReadRepository.Table.Include(o => o.Basket)
                                                           .ThenInclude(b => b.BasketItems)
                                                           .ThenInclude(bi => bi.Product)
                                                           .ThenInclude(p => p.Translations)
                                                           .Include(o => o.Basket)
                                                           .ThenInclude(b => b.BasketItems)
                                                           .ThenInclude(bi => bi.Product)
                                                           .ThenInclude(p => p.ImageFiles)
                                                           .FirstOrDefaultAsync(o => o.Id == Guid.Parse(orderId));

            if (order == null)
                throw new OrderNotFoundException();


            //basketItemlari getirme
            List<GetBasketItemDTO> getBasketItemDTOs = new List<GetBasketItemDTO>();
            //getTotalPrice
            decimal totalPrice = 0;
            order.Basket.BasketItems.ToList().ForEach(bi =>
            {
                // product translationları getirme
                List<GetProductTranslationDTO> getProductTranslationDTOs = new List<GetProductTranslationDTO>();
                bi.Product.Translations.ForEach(pt =>
                {
                    getProductTranslationDTOs.Add(new()
                    {
                        Description = pt.Description,
                        Name = pt.Name,
                        TranslationCode = pt.TranslationCode,
                    });
                });

                // productImage
                List<GetFileDTO> getFileDTOs = new List<GetFileDTO>();
                bi.Product.ImageFiles.ToList().ForEach(f =>
                {
                    getFileDTOs.Add(new()
                    {
                        FileName = f.FileName,
                        Path = f.Path,
                        Id = f.Id.ToString(),
                        Storage = f.Storage,
                    });
                });

                getBasketItemDTOs.Add(new()
                {
                    ProductDTO = new()
                    {
                        CategoryId = bi.Product.CategoryId.ToString(),
                        Id = bi.Product.Id.ToString(),
                        IsActive = bi.Product.IsActive,
                        Price = bi.Product.Price,
                        ProductFiles = getFileDTOs,
                        Translation = getProductTranslationDTOs
                    },
                    Quantity = bi.Quantity,
                    Id = bi.Id.ToString()

                });

                //calculate totalPrice
                totalPrice += (bi.Product.Price*bi.Quantity);

            });


            //orderDto getirme
            GetOrderDTO result = new GetOrderDTO()
            {
                Id = orderId,
                Note = order.Note,
                OrderCode = order.OrderCode,
                BasketItems = getBasketItemDTOs,
                TableNo = order.Basket.TableNo,
                TotalPrice= totalPrice,

            };

            return result;
        }

        public async Task<List<GetOrderDTO>> GetOrdersAsync(int page, int size)
        {
            IQueryable<Order> query = _orderReadRepository.Table.Include(o => o.Basket)
                                                        .ThenInclude(b => b.BasketItems)
                                                        .ThenInclude(bi => bi.Product)
                                                        .ThenInclude(p => p.Translations)
                                                        .Where(o => o.IsActive);

            int totalCount = query.Count();

            List<Order>? orders = null;

            if (page == -1 || size == -1)
            {
                orders = await query.ToListAsync();
            }
            else
            {
                orders = await query.Skip(size * page).Take(size).ToListAsync();
            }


            List<GetOrderDTO> result = new List<GetOrderDTO>();


            orders.ForEach(o =>
            {
                //basketItemlari getirme
                List<GetBasketItemDTO> getBasketItemDTOs = new List<GetBasketItemDTO>();
                //basketItems Total Price
                decimal  totalPrice = 0;
                o.Basket.BasketItems.ToList().ForEach(bi =>
                {
                    
                    // product translationları getirme
                    List<GetProductTranslationDTO> getProductTranslationDTOs = new List<GetProductTranslationDTO>();
                    bi.Product.Translations.ForEach(pt =>
                    {
                        getProductTranslationDTOs.Add(new()
                        {
                            Description = pt.Description,
                            Name = pt.Name,
                            TranslationCode = pt.TranslationCode,
                        });
                    });

                    // productImage
                    List<GetFileDTO> getFileDTOs = new List<GetFileDTO>();
                    bi.Product.ImageFiles.ToList().ForEach(f =>
                    {
                        getFileDTOs.Add(new()
                        {
                            FileName = f.FileName,
                            Path = f.Path,
                            Id = f.Id.ToString(),
                            Storage = f.Storage,
                        });
                    });

                    getBasketItemDTOs.Add(new()
                    {
                        
                        ProductDTO = new()
                        {
                            CategoryId = bi.Product.CategoryId.ToString(),
                            Id = bi.Product.Id.ToString(),
                            IsActive = bi.Product.IsActive,
                            Price = bi.Product.Price,
                            ProductFiles = getFileDTOs,
                            Translation = getProductTranslationDTOs
                        },
                        Quantity = bi.Quantity,
                        Id = bi.Id.ToString()

                    });

                    //calculat totalPrice
                    totalPrice += (bi.Product.Price*bi.Quantity);

                    

                });


                //orderDto ekleme

                result.Add(new GetOrderDTO()
                {
                    Id = o.Id.ToString(),
                    Note = o.Note,
                    OrderCode = o.OrderCode,
                    BasketItems = getBasketItemDTOs,
                    TotalCount = totalCount,
                    TableNo = o.Basket.TableNo,
                    TotalPrice = totalPrice

                });

            });

            return result;

        }
    }
}
