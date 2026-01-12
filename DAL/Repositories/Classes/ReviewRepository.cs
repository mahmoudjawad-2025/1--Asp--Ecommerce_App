using D_A_L.Data_Base;
using DAL.Models;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Classes
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly ApplicationDbContext _context;

        public ReviewRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> HasUserReviewedProduct(string userId, int productId)
        {
            return await _context.Reviews.AnyAsync(r => r.UserId == userId && r.ProductId == productId);
        }

        public async Task AddReviewAsync(Review request, string userId)
        {
            request.UserId = userId;
            request.ReviewDate = DateTime.Now;
            await _context.Reviews.AddAsync(request);
            await _context.SaveChangesAsync();
        }
    }
}
