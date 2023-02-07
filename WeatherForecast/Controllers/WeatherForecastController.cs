using Microsoft.AspNetCore.Mvc;
using WeatherForecast.Services;

namespace WeatherForecast.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeather")]
        public async Task<ActionResult<string>> Get([FromServices] IWeatherService weatherService, 
            [FromServices] IServiceProvider provider)
        {
            var countOfServices = provider.GetServices<IWeatherService>().ToList().Count;
            var service1 = provider.GetServices<IWeatherService>().ToList()[0];
            Console.WriteLine(countOfServices); 
            var data = await service1.GetWeatherData(); // WeatherService1 
            return Ok(data); // return Ok(result);
        }
    }

    public class WeatherData
    {
        public double temp { get; set; }
        public double feels_like { get; set; }
    }
}