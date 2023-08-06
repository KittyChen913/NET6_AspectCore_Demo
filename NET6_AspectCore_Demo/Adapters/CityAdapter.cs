namespace AspectCore_Scrutor_DemoProject.Services;

public class CityAdapter : ICityAdapter
{
    private static readonly string[] Citys = new[]
    {
        "Taipei", "Taichung", "Kaohsiung", "Tainan", "Zhongli", "Hsinchu", "Chiayi", "Zhubei", "Pingzhen", "Bade", "Luodong", "Banqiao"
    };

    public string[] GetCityList()
    {
        return Citys;
    }
}
