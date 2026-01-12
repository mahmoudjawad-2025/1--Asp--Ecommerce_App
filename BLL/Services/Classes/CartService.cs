
using BLL.Services.Interfaces;
using D_A_L.Repositories.Interfaces;
using DAL.DTO.Requests;
using DAL.DTO.Responses;
using DAL.Models;

namespace BLL.Services.Classes
{
    public class CartService : ICartService
    {
        private ICartRepository _cartRepository;

        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public async Task<bool> AddToCartAsync(CartRequest request, string UserId)
        {
            var newItem = new Cart
            {
                productId = request.ProductId,
                userId = UserId,
                count = 1
            };

            return await _cartRepository.AddAsync(newItem) > 0;
        }

        public async Task<CartSummaryResponse> CartSummaryResponseAsync(string UserId)
        {
            var cartItems = await _cartRepository.GetUserCartAsync(UserId);
            var response = new CartSummaryResponse
            {
                Items = cartItems.Select(ci => new CartResponse
                {
                    ProductId = ci.productId,
                    ProductName = ci.product.Name,
                    Count = ci.count,
                    Price = ci.product.Price
                }).ToList()
            };
            return response;
        }

        public async Task<bool> ClearCartAsync(string userId)
        {
            return await _cartRepository.ClearCartAsync(userId);
        }
    }
    
}
