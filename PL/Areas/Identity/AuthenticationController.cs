using B_L_L.Services.Classes;
using B_L_L.Services.Interfaces;
using D_A_L.DTO.Requests;
using D_A_L.DTO.Responses;
using Microsoft.AspNetCore.Mvc;

namespace P_L.Areas.Identity
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Identity")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authernticationService)
        {
            _authenticationService = authernticationService;
        }



        [HttpPost("Register")]
        public async Task<ActionResult<UserResponse>> Register(RegisterRequest registerRequest)
        {
            var result = await _authenticationService.RegisterAsync(registerRequest, Request);
            return Ok(result);
        }



        [HttpPost("Login")]
        public async Task<ActionResult<UserResponse>> Login(LoginRequest loginRequest)
        {
            var result = await _authenticationService.LoginAsync(loginRequest);
            return Ok(result);
        }



        [HttpGet("ConfirmEmail")]
        public async Task<ActionResult<string>> ConfirmEmail([FromQuery] string token, [FromQuery] string userId)
        {
            var result = await _authenticationService.ConfirmEmail(token, userId);
            return Ok(result);
        }



        [HttpPost("forgot-password")]
        public async Task<ActionResult<string>> ForgotPassword([FromBody] ForgotPasswordRequest request)
        {
            var result = await _authenticationService.ForgotPassword(request);
            return Ok(result);
        }



        [HttpPost("reset-password")]
        public async Task<ActionResult<string>> ResetPassword([FromBody] ResetPasswordRequest request)
        {
            var result = await _authenticationService.ResetPassword(request);
            return Ok(result);
        }
    }
}
