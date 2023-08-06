namespace AspectCore_Scrutor_DemoProject.Services;

public class WeatherService : IWeatherService
{
    private readonly IWeatherRepository _weatherRepository;
    private readonly ICityAdapter _cityAdapter;

    public WeatherService(IWeatherRepository weatherRepository, ICityAdapter cityAdapter)
    {
        this._weatherRepository = weatherRepository;
        this._cityAdapter = cityAdapter;
    }

    public IEnumerable<WeatherForecast> GetWeatherForecast()
    {
        return _weatherRepository.GetWeatherForecast();
    }

    public string GetUserName()
    {
        return _weatherRepository.GetUserName();
    }

    public string GetCityList()
    {
        return string.Join(",", _cityAdapter.GetCityList());
    }
}
