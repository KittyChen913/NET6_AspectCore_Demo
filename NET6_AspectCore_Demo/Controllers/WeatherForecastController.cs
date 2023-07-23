using AspectCore_Scrutor_DemoProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspectCore_Scrutor_DemoProject.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IWeatherService weatherService;

    public WeatherForecastController(IWeatherService weatherService)
    {
        this.weatherService = weatherService;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        return weatherService.GetWeatherForecast();
    }

    [HttpPost(Name = "GetUserName")]
    public async Task<string> Post()
    {
        return weatherService.GetUserName();
    }
}