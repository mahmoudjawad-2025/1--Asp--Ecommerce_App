using DAL.DTO.Requests;
using DAL.DTO.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface ICartService
    {
        Task<bool> AddToCartAsync(CartRequest request, string UserId);
        Task<CartSummaryResponse> CartSummaryResponseAsync(string UserId);
        Task<bool> ClearCartAsync(string userId);
    }
}
