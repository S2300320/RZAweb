using Microsoft.EntityFrameworkCore;
using RZAweb.Components;
using RZAweb.Models;
using RZAweb.Services;
using RZAweb.Utilities;


namespace RZAweb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            builder.Services.AddDbContext<TlS2300320RzaContext>(options => options.UseMySql(builder.Configuration.GetConnectionString("MySqlConnection"), new MySqlServerVersion(new Version(8, 0, 29))));
            builder.Services.AddScoped<CustomerService>();
          
            builder.Services.AddScoped<UserSession>();
            builder.Services.AddScoped<AttractionService>();
            builder.Services.AddSingleton<UserSession>();
            builder.Services.AddScoped<TicketService>();
            builder.Services.AddScoped<TicketbookingService>();
          


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
