using ECommerce_MVC.Data;
using ECommerce_MVC.Interfaces;
using ECommerce_MVC.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ECommerce_MVC
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var cstr = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(cstr, ServerVersion.AutoDetect(cstr)));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();
            builder.Services.AddControllersWithViews();


            builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
            builder.Services.AddTransient<IBrandRepository, BrandRepository>();
            builder.Services.AddTransient<IProductRepository, ProductRepository>();
            builder.Services.AddTransient<IFileManager, FileManager>();
            builder.Services.AddTransient<IAnnouncementRepository, AnnouncementRepository>();
            builder.Services.AddTransient<Initializer>();

            /*            builder.Services.AddApiVersioning(config =>
                        {
                            config.DefaultApiVersion = ApiVersion.Default;
                            config.AssumeDefaultVersionWhenUnspecified = true;
                            config.ReportApiVersions = true;
                        });*/
            builder.Services.AddServerSideBlazor();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            var dbInit = app.Services.CreateScope().ServiceProvider.GetRequiredService<Initializer>();
            await dbInit.Initialize();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapBlazorHub();
            app.MapRazorPages();

            app.Run();
        }
    }
}