using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalChallenge.Application.Contracts.Persistence;
using TechnicalChallenge.Domain.Entities;
using TechnicalChallenge.Infrastructure.Persistence;

namespace TechnicalChallenge.Infrastructure.Repositories
{
    public class OrderRepositoryAsync : IOrderRepositoryAsync
    {
        protected readonly NorthwindDbContext _northwindDbContext;
        public OrderRepositoryAsync(NorthwindDbContext northwindDbContext)
        {
            _northwindDbContext = northwindDbContext;
        }

        public async Task<IEnumerable<Order>> GetOrdersAsync()
        {
            var orderList = await _northwindDbContext.Orders.Include("OrderDetails").ToListAsync();
            return orderList;
        }
        public async Task<Order> GetOrderByIdAsync(int id)
        {
            var orderList = await _northwindDbContext.Orders.Include("OrderDetails").FirstOrDefaultAsync(order => order.OrderId == id);
            return orderList;
        }

        public async Task<Order> CreateOrderAsync(Order order)
        {
            await _northwindDbContext.AddAsync(order);
            await _northwindDbContext.SaveChangesAsync();
            return order;
        }

        public async Task<bool> DeleteOrderAsync(Order order)
        {
            _northwindDbContext.Remove(order);
            await _northwindDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<OrderDetail>> AddProductToOrderAsync(int orderId, IEnumerable<OrderDetail> orderDetails)
        {
             _northwindDbContext.OrderDetails.AddRange(orderDetails);
            await _northwindDbContext.SaveChangesAsync();
            return orderDetails;
        }

    }
}
