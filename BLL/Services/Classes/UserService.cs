using BLL.Services.Interfaces;
using D_A_L.Models;
using DAL.DTO.Responses;
using DAL.Repositories.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Classes
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly UserManager<User> _userManager;

        public UserService(IUserRepository userRepository, UserManager<User> userManager)
        {
            _userRepository = userRepository;
            _userManager = userManager;
        }

        public async Task<List<UserDto>> GetAllAsync()
        {
            var users = await _userRepository.GetAllAsync();
            var userDtos = new List<UserDto>();
            foreach (var user in users)
            {
                var role = await _userManager.GetRolesAsync(user);
                userDtos.Add(new UserDto
                {
                    Id = user.Id,
                    FullName = user.FullName,
                    UserName = user.UserName,
                    PhoneNumber = user.PhoneNumber,
                    Email = user.Email,
                    RoleName = role.FirstOrDefault()
                });
            }
            return userDtos;
        }

        public async Task<UserDto> GetByIdAsync(string userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            return user.Adapt<UserDto>();
        }

        public async Task<bool> BlockUserAsync(string userId, int days)
        {
            return await _userRepository.BlockUserAsync(userId, days);
        }

        public async Task<bool> UnBlockUserAsync(string userId)
        {
            return await _userRepository.UnBlockUserAsync(userId);
        }

        public async Task<bool> IsBlockedAsync(string userId)
        {
            return await _userRepository.IsBlockedAsync(userId);
        }


        public async Task<bool> ChangeUserRoleAsync(string userId, string roleName)
        {
            return await _userRepository.ChangeUserRoleAsync(userId, roleName);
        }
    


    }
}
