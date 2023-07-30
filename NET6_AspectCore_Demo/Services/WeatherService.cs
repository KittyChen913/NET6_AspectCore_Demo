namespace AspectCore_Scrutor_DemoProject.Services;

public class WeatherService : IWeatherService
{
    private readonly IWeatherRepository _weatherRepository;

    public WeatherService(IWeatherRepository weatherRepository)
    {
        this._weatherRepository = weatherRepository;
    }

    public IEnumerable<WeatherForecast> GetWeatherForecast()
    {
        return _weatherRepository.GetWeatherForecast();
    }

    public string GetUserName()
    {
        return _weatherRepository.GetUserName();
    }
}
