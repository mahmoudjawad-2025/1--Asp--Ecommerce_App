using BLL.Services.Interfaces;
using DAL.DTO.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using System.Security.Claims;

namespace PL.Areas.Customer
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("customer")]
    [Authorize(Roles = "customer")]
    public class ReviewsController : ControllerBase
    {
        private readonly IReviewService _reviewService;

        public ReviewsController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpPost("")]
        public async Task<IActionResult> AddReview([FromBody] ReviewRequest reviewRequest)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = await _reviewService.AddReviewAsync(reviewRequest, userId);
            return Ok(result);
        }
    }
}
