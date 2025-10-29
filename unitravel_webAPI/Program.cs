using DotNetEnv;
using unitravel_webAPI.Helpers;

namespace unitravel_webAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Adding .env support
            Env.Load();

            builder.Configuration
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            builder.Services.Configure<ApiCredentials>(options =>
            {
                options.BaseUrl = builder.Configuration["TBOAPI:BaseUrl"]!;
                options.Username = builder.Configuration["TBO_USERNAME"] ?? throw new Exception("No variable in the .env file!");
                options.Password = builder.Configuration["TBO_PASSWORD"] ?? throw new Exception("No variable in the .env file!");
            });

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            //builder.Services.AddOpenApi();

            var app = builder.Build();  

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                    options.RoutePrefix = string.Empty;
                });
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
