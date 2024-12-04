using Microsoft.EntityFrameworkCore;
using PassportsApp.Data;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace PassportsApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorPages();

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(
                    builder.Configuration.GetConnectionString("DefaultConnection"),
                    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection")),
                    mysqlOptions => mysqlOptions.EnableRetryOnFailure()
                ).LogTo(Console.WriteLine, LogLevel.Information)
            );

            builder.Services.AddAuthentication("Cookies")
                .AddCookie(options =>
                {
                    options.LoginPath = "/Account/Login";
                });

            var app = builder.Build();

            if (args.Length == 1 && args[0].ToLower() == "seeddata")
            {
                Seed.SeedData(app);
            }

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Account}/{action=Login}/{id?}");

            //app.MapControllerRoute(
               // name: "default",
              //  pattern: "{controller=Review}/{action=Passports}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Reviews}/{action=Index}/{id?}");



            //app.MapControllerRoute(
            // name: "reviews",
            //pattern: "Reviews/{action=Passports}/{id?}",
            //defaults: new { controller = "Reviews" });

            app.MapRazorPages();

            app.Run();
        }
    }
}
