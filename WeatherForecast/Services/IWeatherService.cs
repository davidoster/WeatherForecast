namespace WeatherForecast.Services
{
    public interface IWeatherService
    {
        Task<string> GetWeatherData();
    }
}