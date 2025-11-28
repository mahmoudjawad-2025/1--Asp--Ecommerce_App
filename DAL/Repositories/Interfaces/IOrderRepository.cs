using DAL.Models.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        //Task AddAsync(Order? order);
        Task<Order?> GetUserByOrderAsync(int orderId);
        Task<Order> AddOrderAsync(Order order);
        Task<bool> ChangeStatusAsync(int orderId, OrderStatusEnum newStatus);
        Task<List<Order>> GetOrderByUserAsync(string userId);
        Task<List<Order>> GetByStatusAsync(OrderStatusEnum status);
        Task<bool> UserHasApprovedOrderForProductAsync(string userId, int productId);
    }
}
