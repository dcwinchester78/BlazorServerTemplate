namespace WeatherApp;

public class WeatherForecastService
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private static readonly Random Random = new Random();

    public async Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate)
    {
        // Simulate async work
        await Task.Delay(1000); // Can add a small delay here to demonstrate streaming rendering more clearly if needed

        var forecasts = Enumerable.Range(0, 7).Select(index =>
        {
            var date = startDate.AddDays(index);
            return new WeatherForecast
            {
                Date = date,
                TemperatureC = Random.Next(-20, 55),
                Summary = Summaries[Random.Next(Summaries.Length)]
            };
        }).ToArray();

        return forecasts;
    }
}
