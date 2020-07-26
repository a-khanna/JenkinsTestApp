using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Logic
{
    public interface IWeatherLogic
    {
        IEnumerable<WeatherForecast> GetWeather();
    }
}
