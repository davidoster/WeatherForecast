using WeatherForecast.Services;

namespace WeatherForecast
{
    public class Program
    {
        private const string _lat = "50.073658";
        private const string _lon = "14.418540";
        private const string _API_key = "d368d9c1574a74a6f209d10c02aeef8d";

        const string APICALL = $"https://api.openweathermap.org/data/3.0/onecall?lat={_lat}&lon={_lon}&appid={_API_key}";
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddTransient<WeatherService>();
          

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}