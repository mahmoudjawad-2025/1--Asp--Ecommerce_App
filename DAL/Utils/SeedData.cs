using D_A_L.Data_Base;
using D_A_L.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_A_L.Utils
{
    public class SeedData : ISeedData
    {
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManger;
        private readonly UserManager<User> _userManager;

        public SeedData(ApplicationDbContext context, RoleManager<IdentityRole> roleManger, UserManager<User> userManager)
        {
            _context = context;
            _roleManger = roleManger;
            _userManager = userManager;
        }
        public async Task DataSeedingAsync()
        {
            if ((await _context.Database.GetPendingMigrationsAsync()).Any())
            {
                await _context.Database.MigrateAsync();
            }

            if(!await _context.Categories.AnyAsync())
            {
                await _context.Categories.AddRangeAsync(
                    new Category { name = "Clothes"},
                    new Category { name = "Mobiles"}
                    );
            }
            if (!await _context.Brands.AnyAsync())
            {
                await _context.Brands.AddRangeAsync(
                    new Brand { name = "Android", MainImage= "sample.jpg" },
                    new Brand { name = "IOS", MainImage="sample.jpg" }
                    );
            }
            await _context.SaveChangesAsync();
        }

        public async Task IdentityDataSeedingAsync()
        {
            if (!await _roleManger.Roles.AnyAsync())
            {
                await _roleManger.CreateAsync(new IdentityRole("admin"));
                await _roleManger.CreateAsync(new IdentityRole("superAdmin"));
                await _roleManger.CreateAsync(new IdentityRole("customer"));
            }

            if (!await _userManager.Users.AnyAsync())
            {
                var user1 = new User()
                {
                    FullName = "Mahmoud Jawad",
                    Email = "mahmoodjawad1111@gmail.com",
                    PhoneNumber = "0599777707",
                    UserName = "m.jawad",
                    EmailConfirmed = true,
                };
                var user2 = new User()
                {
                    FullName = "Omar Sameer",
                    Email = "o.sameer@outlook.com",
                    PhoneNumber = "0599777707",
                    UserName = "o.sameer",
                    EmailConfirmed = true,
                };
                var user3 = new User()
                {
                    FullName = "Zakaria Ahmad",
                    Email = "z.ahmad@outlook.com",
                    PhoneNumber = "0599777707",
                    UserName = "z.ahmad",
                    EmailConfirmed = true,
                };
                await _userManager.CreateAsync(user1, "mmmm");
                await _userManager.CreateAsync(user2, "Pass@2222");
                await _userManager.CreateAsync(user3, "Pass@3333");

                await _userManager.AddToRoleAsync(user1, "superAdmin");
                await _userManager.AddToRoleAsync(user2, "admin");
                await _userManager.AddToRoleAsync(user3, "customer");
            }
        }
    }
}
