using Microsoft.AspNetCore.Mvc;
using Net.WebApi.Template.Domain.Models;

namespace Net.WebApi.Template.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        // Fields
        private readonly ILogger<WeatherForecastController> _logger;

        // Ctor
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        // Endpoints
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return WeatherForecast.GetDummyData();
        }
    }
}
