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
        public ActionResult<WeatherData> Get([FromServices] IWeatherService weatherService, [FromServices] IServiceProvider provider)
        {
            var countOfServices = provider.GetServices<IWeatherService>().ToList().Count;
            //var weather2 = provider.GetService<WeatherService2>().GetType(); // can't do it
            Console.WriteLine(countOfServices); // can't do it
            //Console.WriteLine(weather2);
            var data = weatherService.GetWeatherData(); // WeatherService2 
            //var result = // data is a JSON and send it to the requestor
            return Ok(data); // return Ok(result);
        }
    }

    public class WeatherData
    {
        public double temp { get; set; }
        public double feels_like { get; set; }
    }
}