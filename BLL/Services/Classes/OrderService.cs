using B_L_L.Services.Interfaces;
using BLL.Services.Interfaces;
using D_A_L.Models;
using D_A_L.Repositories.Interfaces;
using DAL.Models.DAL.Models;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Classes
{
    public class OrderService : IOrderService
    {

        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository repository)
        {
            _orderRepository = repository;
        }

        public async Task<Order?> AddOrderAsync(Order order)
        {
            return await _orderRepository.AddOrderAsync(order);
        }

        public async Task<bool> ChangeStatusAsync(int orderId, OrderStatusEnum newStatus)
        {
            return await _orderRepository.ChangeStatusAsync(orderId, newStatus);
        }

        public async Task<List<Order>> GetByStatusAsync(OrderStatusEnum status)
        {
            return await _orderRepository.GetByStatusAsync(status);
        }

        public async Task<List<Order>> GetOrderByUserAsync(string userId)
        {
            return await _orderRepository.GetOrderByUserAsync(userId);
        }

        public async Task<Order?> GetUserByOrderAsync(int orderId)
        {
            return await _orderRepository.GetUserByOrderAsync(orderId);
        }
    }
}
