using Shouldly;

namespace Playground.xUnit;

public class WeatherForecastTests
{
    private readonly WeatherForecast _weatherForecast;

    public WeatherForecastTests()
    {
        _weatherForecast = new WeatherForecast();
    }

    [Fact]
    public void Should_Create_New_WeatherForecast()
    {
        Assert.NotNull(_weatherForecast);
    }

    [Fact]
    public void Should_Create_New_WeatherForecast_Shouldly()
    {
        _weatherForecast.ShouldNotBe(null);
    }
}