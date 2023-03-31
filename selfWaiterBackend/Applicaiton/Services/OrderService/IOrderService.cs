using Applicaiton.DTOs.OrderDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Services.OrderService
{
    public interface IOrderService
    {
        Task CreateOrderAsync(CreateOrderDTO createOrderDTO);
        Task<List<GetOrderDTO>> GetOrdersAsync(int page, int size);
        Task<GetOrderDTO> GetOrderById(string orderId);
        Task CompleteOrder(string orderId);
        
    }
}
