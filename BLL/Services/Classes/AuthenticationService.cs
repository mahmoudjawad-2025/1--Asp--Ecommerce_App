using Azure.Core;
using B_L_L.Services.Interfaces;
using D_A_L.DTO.Requests;
using D_A_L.DTO.Responses;
using D_A_L.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace B_L_L.Services.Classes
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IEmailSender _emailSender;
        private readonly SignInManager<User> _signInManager;

        public AuthenticationService(
            UserManager<User> userManager, IConfiguration configuration, IEmailSender emailSender, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _configuration = configuration;
            _emailSender = emailSender;
            _signInManager = signInManager;
        }
        public async Task<UserResponse> RegisterAsync(RegisterRequest registerRequest, HttpRequest request)
        {
            var user = new User()
            {
                FullName = registerRequest.FullName,
                Email = registerRequest.Email,
                PhoneNumber = registerRequest.PhoneNumber,
                UserName = registerRequest.UserName,
            };

            var result = await _userManager.CreateAsync(user, registerRequest.Password);

            if (result.Succeeded)
            {
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var secapedToken = Uri.EscapeDataString(token);
                var emailUrl = $"{request.Scheme}://{request.Host}/api/Identity/Authentication/ConfirmEmail?token={secapedToken}&userId={user.Id}";

                await _userManager.AddToRoleAsync(user, "customer");
                await _emailSender.SendEmailAsync(user.Email, "Welcome", $"Hello {user.FullName} - <a href='{emailUrl}'> Confirm </a>");
                return new UserResponse()
                {
                    token = registerRequest.Email,
                };
            }
            else
            {
                throw new Exception($"{result.Errors}");
            }
        }



        public async Task<UserResponse> LoginAsync(LoginRequest loginRequest)
        {
            var user = await _userManager.FindByEmailAsync(loginRequest.Email);
            if (user is null)
            {
                throw new Exception("Invalid email or password");
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, loginRequest.Password, true);
            if (result.Succeeded)
            {
                return new UserResponse
                {
                    token = await CreateTokenAsync(user)
                };
            }
            else if (result.IsLockedOut)
            {
                throw new Exception("your account is locked");
            }
            else if (result.IsNotAllowed)
            {
                throw new Exception("please confirm your email");
            }
            else
            {
                throw new Exception("please confirm your email");
            }
        }

        private async Task<string> CreateTokenAsync(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.NameIdentifier, user.Id)
            };

            var roles = await _userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("jwtOptions")["SecretKey"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(15),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


        public async Task<string> ConfirmEmail(string token, string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user is null)
            {
                throw new Exception("User not found");
            }

            var result = await _userManager.ConfirmEmailAsync(user, token);

            if (result.Succeeded)
            {
                return "Email confirmed successfully";
            }

            return "Email confirmation failed";
        }

        public async Task<bool> ForgotPassword(ForgotPasswordRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user is null) throw new Exception("user not found");

            var random = new Random();
            var code = random.Next(1000, 9999).ToString();

            user.ResetPasswordCode = code;
            user.ResetPasswordCodeExpiry = DateTime.UtcNow.AddMinutes(15);

            await _userManager.UpdateAsync(user);

            await _emailSender.SendEmailAsync(request.Email, "reset password", $"<p>code is {code}</p>");

            return true;
        }

        public async Task<bool> ResetPassword(ResetPasswordRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.email);
            if (user is null) throw new Exception("user not found");

            if (user.ResetPasswordCode != request.code) return false;

            if (user.ResetPasswordCodeExpiry < DateTime.UtcNow) return false;

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);

            var result = await _userManager.ResetPasswordAsync(user, token, request.newPassword);

            if (result.Succeeded)
                await _emailSender.SendEmailAsync(request.email, "change password", "<h1> your password is changed </h1>");

            return true;
        }

    }
}
