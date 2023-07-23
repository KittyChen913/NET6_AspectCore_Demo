using NET6_AspectCore_Demo;

namespace AspectCore_Scrutor_DemoProject.Services;

public interface IWeatherService
{
    [CustomInterceptor]
    IEnumerable<WeatherForecast> GetWeatherForecast();
    string GetUserName();
}