using Microsoft.EntityFrameworkCore;
using MvcApplication_pr01.Data;

namespace MvcApplication_pr01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // MVC + API support
            builder.Services.AddControllersWithViews();
            builder.Services.AddControllers(); // 👈 Add this for [ApiController]s

            // EF Core with SQL Server
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.MapStaticAssets();

            // Default MVC route
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            // 👇 Needed to activate attribute-routed API controllers
            app.MapControllers();

            app.Run();
        }
    }
}
