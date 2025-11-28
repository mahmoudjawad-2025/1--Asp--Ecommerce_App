using D_A_L.Data_Base;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface IReviewRepository
    {
        Task<bool> HasUserReviewedProduct(string userId, int productId);
        Task AddReviewAsync(Review request, string userId);
    }
}
