namespace AspectCore_Scrutor_DemoProject.Services;

public interface IWeatherService
{
    IEnumerable<WeatherForecast> GetWeatherForecast();
    string GetUserName();
}