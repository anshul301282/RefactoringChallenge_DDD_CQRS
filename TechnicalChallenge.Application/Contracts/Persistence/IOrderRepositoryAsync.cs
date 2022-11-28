
using System.Collections.Generic;
using System.Threading.Tasks;
using TechnicalChallenge.Domain.Entities;

namespace TechnicalChallenge.Application.Contracts.Persistence
{
    public interface IOrderRepositoryAsync
    {
        Task<IEnumerable<Order>> GetOrdersAsync();
        Task<Order> GetOrderByIdAsync(int id);
        Task<Order> CreateOrderAsync(Order product);
        Task<IEnumerable<OrderDetail>> AddProductToOrderAsync(int orderId, IEnumerable<OrderDetail> orderDetails);
        Task<bool> DeleteOrderAsync(Order order);

    }
}
