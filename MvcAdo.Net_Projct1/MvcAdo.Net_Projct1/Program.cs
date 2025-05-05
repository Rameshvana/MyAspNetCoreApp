using MvcAdo.Net_Projct1.Models.Student;

namespace MvcAdo.Net_Projct1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add MVC services
            builder.Services.AddControllersWithViews();

            // Inject configuration (needed for accessing connection string in StudentRepository)
            builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

            // Optional: Register StudentRepository for Dependency Injection
            builder.Services.AddScoped<StudentRepo>();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts(); // Enforces HTTPS in production
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles(); // Serves static files (CSS, JS, etc.)

            app.UseRouting();
            app.UseAuthorization();

            // Route setup (defaults to Student/Index)
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Student}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{action=Index}/{controller=Student}/{id?}");

          

            app.Run();
        }
    }
}
