using D_A_L.Data_Base;
using DAL.Models.DAL.Models;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Classes
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderRepository(ApplicationDbContext context)
        {
            _context = context; 
        }

        public async Task<Order> AddOrderAsync(Order order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
            return order;
        }

        public async Task<Order?> GetUserByOrderAsync(int orderId)
        {
            return await _context.Orders.Include(o => o.User)
                .FirstOrDefaultAsync(o => o.Id == orderId);
        }

        public async Task<List<Order>> GetByStatusAsync(OrderStatusEnum status)
        {
            return await _context.Orders.Where(o => o.Status == status)
                .OrderByDescending(o => o.OrderDate).ToListAsync();
        }

        public async Task<List<Order>> GetOrderByUserAsync(string userId)
        {
            return await _context.Orders.Include(o => o.User)
                .OrderByDescending(o => o.OrderDate).ToListAsync();
        }

        public async Task<bool> ChangeStatusAsync(int orderId, OrderStatusEnum newStatus)
        {
            var order = await _context.Orders.FindAsync(orderId);
            if (order is null) return false;
            order.Status = newStatus;
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<bool> UserHasApprovedOrderForProductAsync(string userId, int productId)
        {
            return await _context.Orders.Include(o => o.OrderItems)
                .AnyAsync(e => e.UserId == userId && e.Status == OrderStatusEnum.Approved &&
                    e.OrderItems.Any(oi => oi.ProductId == productId));
        }
    }
}
