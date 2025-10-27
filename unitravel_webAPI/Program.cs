using DotNetEnv;
namespace unitravel_webAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Adding .env suuport
            DotNetEnv.Env.Load();
            string API_USERNAME = Environment.GetEnvironmentVariable("API_USERNAME") ?? string.Empty;
            string API_PASSWORD = Environment.GetEnvironmentVariable("API_PASSWORD") ?? string.Empty;

            // idk something really interesting blah blah blah
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
