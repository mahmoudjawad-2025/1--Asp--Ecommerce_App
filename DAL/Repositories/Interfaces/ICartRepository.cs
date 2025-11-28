using D_A_L.Models;
using D_A_L.Repositories.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_A_L.Repositories.Interfaces
{
    public interface ICartRepository 
    {
        Task<int> AddAsync(Cart cart);
        Task<List<Cart>> GetUserCartAsync(string UserId);
        Task<bool> ClearCartAsync(string userId);
        
    }
}
