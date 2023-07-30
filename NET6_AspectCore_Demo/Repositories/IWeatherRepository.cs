namespace AspectCore_Scrutor_DemoProject.Services;

public interface IWeatherRepository
{
    IEnumerable<WeatherForecast> GetWeatherForecast();
    string GetUserName();
}