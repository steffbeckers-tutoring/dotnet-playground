using Shouldly;

namespace Playground.xUnit;

public class WeatherForecastTests
{
    [Fact]
    public void Should_Create_New_WeatherForecast()
    {
        // Act
        WeatherForecast weatherForecast = new WeatherForecast();

        // Assert
        Assert.NotNull(weatherForecast);
    }

    [Fact]
    public void Should_Create_New_WeatherForecast_Shouldly()
    {
        // Act
        WeatherForecast weatherForecast = new WeatherForecast();

        // Assert
        weatherForecast.ShouldNotBe(null);
    }
}