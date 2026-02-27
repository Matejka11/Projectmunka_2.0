using Microsoft.EntityFrameworkCore;
using Projectmunka.Data;

namespace Projectmunka
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<RegisztraltakDbContext>(options => options.UseInMemoryDatabase("RegisztraltakDb"));
            builder.Services.AddDbContext<TermekekDbContext>(options => options.UseInMemoryDatabase("TermekekDb"));
            builder.Services.AddDbContext<RendelesDbContext>(options => options.UseInMemoryDatabase("RendelesekDb"));
            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<RegisztraltakDbContext>();

                context.Database.EnsureCreated();
            }
            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<TermekekDbContext>();

                context.Database.EnsureCreated();
            }

            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<RendelesDbContext>();

                context.Database.EnsureCreated();
            }


            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
