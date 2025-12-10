namespace ApiLayerTests;

public class UnitTest1
{
    [Fact(Skip = "Not implemented yet")]
    public void Should_convert_C_to_F()
    {
        WeatherForecast forecast = new(DateOnly.FromDateTime(DateTime.Now), 25, "Warm");
        Assert.Equal(76, forecast.TemperatureF);
    }
}
