
using B_L_L.Services.Classes;
using B_L_L.Services.Interfaces;
using BLL.Services.Classes;
using BLL.Services.Interfaces;
using D_A_L.Data_Base;
using D_A_L.Models;
using D_A_L.Repositories.Classes;
using D_A_L.Repositories.Interfaces;
using D_A_L.Utils;
using DAL.Repositories.Classes;
using DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using Scalar;
using Scalar.AspNetCore;
using Stripe;
using System.Text;

namespace P_L
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddOpenApi();
            var userPolicy = "userPolicy";
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: userPolicy, policy =>
                {
                    policy.AllowAnyOrigin();
                });
            });
            // database
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



            // Dependency Injection Setup
            builder.Services.AddScoped<ICategoryRepository,CategoryRepository>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<IBrandRepository, BrandRepository>();
            builder.Services.AddScoped<IBrandService, BrandService>();
            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<IProductService, B_L_L.Services.Classes.ProductService>();
            builder.Services.AddScoped<IFileService, B_L_L.Services.Classes.FileService>();
            builder.Services.AddScoped<ISeedData, SeedData>();
            builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
            builder.Services.AddScoped<IEmailSender, EmailSending>();
            builder.Services.AddScoped<ICartService, CartService>();
            builder.Services.AddScoped<ICartRepository, CartRepository>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<ICheckOutService, CheckOutService>();
            builder.Services.AddScoped<IOrderService, OrderService>();
            builder.Services.AddScoped<IOrderRepository, OrderRepository>();
            builder.Services.AddScoped<IReviewService, BLL.Services.Classes.ReviewService>();
            builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
            builder.Services.AddScoped<IOrderItemRepository, OrderItemRepository>();
            builder.Services.AddScoped<ReportService>();
            builder.Services.AddIdentity<User,IdentityRole>(options =>
            {
                options.Password.RequiredLength = 4;
                options.Password.RequireDigit = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = true;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);
                options.Lockout.MaxFailedAccessAttempts = 5;
            }
            ).AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();



            //identity - auth
            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(builder.Configuration.GetSection("jwtOptions")["SecretKey"]))
                };
            });

            // Payment stripe 
            builder.Services.Configure<Strings>(builder.Configuration.GetSection("Stripe"));
            StripeConfiguration.ApiKey = builder.Configuration["Stripe:SecretKey"];

            // app
            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.MapScalarApiReference();
            }



            // seedData
            var scope = app.Services.CreateScope();
            var seedDataObject = scope.ServiceProvider.GetRequiredService<ISeedData>();
            await seedDataObject.DataSeedingAsync();
            await seedDataObject.IdentityDataSeedingAsync();



            // last part
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseCors(userPolicy);
            app.UseAuthorization();
            app.UseStaticFiles();
            app.MapControllers();
            app.Run();
        }
    }
}
