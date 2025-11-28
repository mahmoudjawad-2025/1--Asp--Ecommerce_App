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
    [Area("customer")]
    [Authorize(Roles = "customer")]
    public class CheckOutsController : ControllerBase
    {
        private readonly ICheckOutService _checkOutService;

        public CheckOutsController(ICheckOutService checkOutService)
        {
            _checkOutService = checkOutService;
        }

        [HttpPost("payment")]
        public async Task<IActionResult> Payment([FromBody] CheckOutRequest request)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var response = await _checkOutService.ProcessPaymentAsync(request, userId, Request);
            return Ok(response);
        }

        [HttpGet("Success/{orderId}")]
        [AllowAnonymous]
        public async Task<IActionResult> Success([FromRoute] int orderId)
        {
            var result = await _checkOutService.HandlePaymentSuccessAsync(orderId);
            return Ok(result);
        }
    }
}
