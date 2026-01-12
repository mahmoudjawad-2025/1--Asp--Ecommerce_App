using DAL.DTO.Requests;
using DAL.DTO.Responses;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface ICheckOutService
    {
        Task<CheckOutResponse> ProcessPaymentAsync(CheckOutRequest request, string UserId, HttpRequest Request);
        Task<bool> HandlePaymentSuccessAsync(int orderId); 
    }
}
