using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Logic
{
    public class WeatherLogic : IWeatherLogic
    {
        private static readonly string[] Summaries = new[]
        {
            "Warm", "Balmy", "Hot"
        };

        public IEnumerable<WeatherForecast> GetWeather()
        {
            return Enumerable.Range(0, 3).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = 30 + index,
                Summary = Summaries[index]
            });
        }
    }
}
