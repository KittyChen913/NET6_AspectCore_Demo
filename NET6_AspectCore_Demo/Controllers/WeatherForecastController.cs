using AspectCore_Scrutor_DemoProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspectCore_Scrutor_DemoProject.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IWeatherService weatherService;

    public WeatherForecastController(IWeatherService weatherService)
    {
        this.weatherService = weatherService;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IEnumerable<WeatherForecast>> GetWeatherForecast()
    {
        return weatherService.GetWeatherForecast();
    }

    [HttpPost(Name = "GetUserName")]
    public async Task<string> GetUserName()
    {
        return weatherService.GetUserName();
    }

    [HttpPost(Name = "GetCityList")]
    public async Task<string> GetCityList()
    {
        return weatherService.GetCityList();
    }
}