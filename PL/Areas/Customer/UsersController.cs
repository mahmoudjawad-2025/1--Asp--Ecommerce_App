using BLL.Services.Interfaces;
using DAL.DTO.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PL.Areas.Customer
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("customer")]
    //[Authorize(Roles = "customer")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById([FromRoute] string id)
        {
            var user = await _userService.GetByIdAsync(id);
            return Ok(user);
        }

        [HttpPatch("block/{userId}")]
        public async Task<IActionResult> BlockUser([FromRoute] string userId, [FromBody] int days)
        {
            var result = await _userService.BlockUserAsync(userId, days);
            return Ok(result);
        }

        [HttpPatch("unblock/{userId}")]
        public async Task<IActionResult> UnBlockUser([FromRoute] string userId)
        {
            var result = await _userService.UnBlockUserAsync(userId);
            return Ok(result);
        }

        [HttpPatch("isblock/{userId}")]
        public async Task<IActionResult> IsBlockedUser([FromRoute] string userId)
        {
            var result = await _userService.IsBlockedAsync(userId);
            return Ok(result);
        }

        [HttpPatch("changeRole/{userId}")]
        public async Task<IActionResult> ChangeRole([FromRoute] string userId, [FromBody] ChangeRoleRequest request)
        {
            var result = await _userService.ChangeUserRoleAsync(userId, request.RoleName);
            return Ok(new { message = "role changed successfully" });
        }
    }
}
