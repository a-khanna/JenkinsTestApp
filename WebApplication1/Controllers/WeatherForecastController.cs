using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Logic;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherLogic _weatherLogic;

        public WeatherForecastController(IWeatherLogic weatherLogic)
        {
            _weatherLogic = weatherLogic;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return _weatherLogic.GetWeather();
        }
    }
}
