using BLL.Services.Interfaces;
using DAL.DTO.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace PL.Areas.Customer
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Customer")]
    [Authorize(Roles = "customer")]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpPost("")]
        public async Task<IActionResult> AddToCart(CartRequest request)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = await _cartService.AddToCartAsync(request, userId);

            return result ? Ok() : BadRequest();
        }

        [HttpGet("")]
        public async Task<IActionResult> GetUserCart()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = await _cartService.CartSummaryResponseAsync(userId);
            return Ok(result);
        }
    }
}
