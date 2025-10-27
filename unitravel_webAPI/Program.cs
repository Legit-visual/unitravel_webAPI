using DotNetEnv;
using unitravel_webAPI.Models;
namespace unitravel_webAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Adding .env suuport
            DotNetEnv.Env.Load();

            // Credentials class, which can be used for further communication
            ApiCredentials credentials = new ApiCredentials
            {
                Username = Environment.GetEnvironmentVariable("API_USERNAME") ?? string.Empty,
                Password = Environment.GetEnvironmentVariable("API_PASSWORD") ?? string.Empty
            };

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();  

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
