using ECommerce_MVC.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ECommerce_MVC
{
    public class Initializer
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public Initializer(ApplicationDbContext context, UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            this._context = context;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        public async Task Initialize()
        {
            if ((await _context.Database.GetPendingMigrationsAsync()).Any())
                await _context.Database.MigrateAsync();



            if (_context.Roles.Any(r => r.Name == "Admin")) return;

            await roleManager.CreateAsync(new IdentityRole("Admin"));

            var res = await userManager.CreateAsync(new ApplicationUser
            {
                FullName = "Site Owner",
                Address = "Oran",
                UserName = "owner@site.com",
                Email = "owner@site.com",
                EmailConfirmed = true
            }, "Owner@Site123");

            var admin = await userManager.FindByNameAsync("owner@site.com");

            await userManager.AddToRoleAsync(admin, "Admin");
        }
    }
}