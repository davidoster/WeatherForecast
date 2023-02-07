namespace WeatherForecast.Services
{
    public class WeatherService : IWeatherService
    {
        private const string _lat = "50.073658";
        private const string _lon = "14.418540";
        private const string _API_key = "d368d9c1574a74a6f209d10c02aeef8d";

        const string APICALL = $"https://api.openweathermap.org/data/3.0/onecall?lat={_lat}&lon={_lon}&appid={_API_key}";

        public async Task<string> GetWeatherData()
        {
            // send a get request to OpenWeatherAPI - HttpClient
            HttpClient httpClient = new HttpClient();
            //httpClient.BaseAddress = new Uri(APICALL);
            var result = await httpClient.GetAsync(APICALL);
            // we get a JSON and do some kind of business login and return a new JSON to the caller
            return await result.Content.ReadAsStringAsync();
        }
    }

    public class WeatherService2 : IWeatherService
    {
        public string TEST = "TEST";
        public const string SAMPLE_API_RESPONSE = @"""main"": {
        ""temp"": 100.39,
        ""feels_like"": 286.38,
        ""temp_min"": 286.69,
        ""temp_max"": 287.39,
        ""pressure"": 1021,
        ""sea_level"": 1021,
        ""grnd_level"": 1018,
        ""humidity"": 58,
        ""temp_kf"": 0.7
      }";

        public async Task<string> GetWeatherData()
        {
            // send a get request to OpenWeatherAPI - HttpClient
            // we get a JSON and do some kind of business login and return a new JSON to the caller
            return SAMPLE_API_RESPONSE;
        }
    }
}
