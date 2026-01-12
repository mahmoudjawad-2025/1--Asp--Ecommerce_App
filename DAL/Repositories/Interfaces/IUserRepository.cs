using D_A_L.Models;
using DAL.DTO.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();
        Task<User> GetByIdAsync(string userId);
        Task<bool> IsBlockedAsync(string userId);
        Task<bool> UnBlockUserAsync(string userId);
        Task<bool> BlockUserAsync(string userId, int days);
        Task<bool> ChangeUserRoleAsync(string userId, string roleName);
    }
}
