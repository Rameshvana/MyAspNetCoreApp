using Blazor_StudentApp.Components;
using Blazor_StudentApp.Connection;
using Microsoft.EntityFrameworkCore;

namespace Blazor_StudentApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // ✅ Register HttpClient (for Blazor components that use it)
            builder.Services.AddHttpClient();

            // ✅ Register EF Core with SQL Server
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // ✅ Register Razor Components and Controllers
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            builder.Services.AddControllers(); // ✅ API Controller support

            // ✅ OPTIONAL: Add CORS if API is being called from outside
            // builder.Services.AddCors(options =>
            // {
            //     options.AddPolicy("AllowAll", policy =>
            //         policy.AllowAnyOrigin()
            //               .AllowAnyHeader()
            //               .AllowAnyMethod());
            // });

            var app = builder.Build();

            // ✅ API Controllers routing
            app.MapControllers();

            // ✅ Middleware pipeline configuration
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseAntiforgery();

            //builder.Services.AddCors(options =>
            //{
            //    options.AddPolicy("AllowAll", builder =>
            //        builder.AllowAnyOrigin()
            //               .AllowAnyMethod()
            //               .AllowAnyHeader());
            //});

            //app.UseCors("AllowAll");


            // app.UseCors("AllowAll"); // Uncomment only if CORS needed

            app.MapStaticAssets();
            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
