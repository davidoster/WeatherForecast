namespace WeatherForecast.Services
{
    public class WeatherService
    {
        public string TEST = "TEST";
        public const string SAMPLE_API_RESPONSE = @"""main"": {
        ""temp"": 287.39,
        ""feels_like"": 286.38,
        ""temp_min"": 286.69,
        ""temp_max"": 287.39,
        ""pressure"": 1021,
        ""sea_level"": 1021,
        ""grnd_level"": 1018,
        ""humidity"": 58,
        ""temp_kf"": 0.7
      }";

      public string GetWeatherData()
      {
            // send a get request to OpenWeatherAPI - HttpClient
            // we get a JSON and do some kind of business login and return a new JSON to the caller
            return SAMPLE_API_RESPONSE;
      }
    }
}
