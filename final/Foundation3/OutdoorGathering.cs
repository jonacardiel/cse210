public class OutdoorGathering : BaseEvent
{
    public string WeatherForecast ;

    public  string GetFullDetails()
    {
        return base.GetStandardDetails() + $"\nWeather Forecast: {WeatherForecast}";
    }
}