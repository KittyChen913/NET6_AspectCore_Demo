using AspectCore.DynamicProxy;
using NET6_AspectCore_Demo;

namespace AspectCore_Scrutor_DemoProject.Services;

public interface IWeatherService
{
    [ServiceInterceptor(typeof(CustomInterceptorAttribute))]
    IEnumerable<WeatherForecast> GetWeatherForecast();
    string GetUserName();
}