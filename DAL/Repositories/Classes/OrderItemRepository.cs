using D_A_L.Data_Base;
using DAL.Models;
using DAL.Models.DAL.Models;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Classes
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddRangeAsync(List<OrderItem> items)
        {
            await _context.OrderItems.AddRangeAsync(items);
            await _context.SaveChangesAsync();
        } 
    }
}
