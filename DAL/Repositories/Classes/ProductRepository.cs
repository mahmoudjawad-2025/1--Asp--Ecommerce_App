using D_A_L.Data_Base;
using D_A_L.DTO.Responses;
using D_A_L.Models;
using D_A_L.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_A_L.Repositories.Classes
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task DecreaseQuantityAsync(List<(int productId, int quantity)> items)
        {
            var productIds = items.Select(i => i.productId).ToList();
            var products = await _context.Products.Where(p => productIds.Contains(p.id)).ToListAsync();

            foreach (var product in products)
            {
                var item = items.First(i => i.productId == product.id);
                if (product.Quantity < item.quantity)
                {
                    throw new Exception("not enough stock available");
                }
                product.Quantity -= item.quantity;
            }

            await _context.SaveChangesAsync();
        }

        public List<Product> GetAllProductsWithImage()
        {
            return _context.Products
                .Include(p => p.SubImages)
                .Include(p => p.Reviews)
                .ThenInclude(r => r.User)
                .ToList();
        }
    }
}
