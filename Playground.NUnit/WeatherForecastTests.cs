namespace Playground.NUnit;

public class WeatherForecastTests
{
    private WeatherForecast _weatherForecast;

    [SetUp]
    public void Setup()
    {
        _weatherForecast = new WeatherForecast();
    }

    [Test]
    public void Should_Create_New_WeatherForecast()
    {
        Assert.That(_weatherForecast, Is.Not.Null);
    }
}