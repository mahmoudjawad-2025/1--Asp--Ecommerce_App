using D_A_L.Models;
using DAL.DTO.Responses;
using DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Classes
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<User> _userManager;

        public UserRepository(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _userManager.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(string userId)
        {
            return await _userManager.FindByIdAsync(userId);
        }

        public async Task<bool> IsBlockedAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user is null) return false;
            return user.LockoutEnd.HasValue && user.LockoutEnd > DateTime.UtcNow;
        }

        public async Task<bool> UnBlockUserAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user is null) return false;
            user.LockoutEnd = null;
            var result = await _userManager.UpdateAsync(user);
            return result.Succeeded;
        }

        public async Task<bool> BlockUserAsync(string userId, int days)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user is null) return false;
            user.LockoutEnd = DateTime.UtcNow.AddDays(days);
            var result = await _userManager.UpdateAsync(user);
            return result.Succeeded;
        }
        public async Task<bool> ChangeUserRoleAsync(string userId, string roleName)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user is null) return false;
            var currentRoles = await _userManager.GetRolesAsync(user);
            var removeResult = await _userManager.RemoveFromRolesAsync(user, currentRoles);
            var addResult = await _userManager.AddToRoleAsync(user, roleName);
            return removeResult.Succeeded;
        }
    }
}
