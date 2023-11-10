using Microsoft.AspNetCore.Mvc;

namespace TradingBot.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger _logger;

    public WeatherForecastController(ILogger logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public void Create()
    {
    }
}