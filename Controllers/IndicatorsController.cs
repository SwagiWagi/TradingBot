using Microsoft.AspNetCore.Mvc;
using TradingBot.Trader;
using TradingBot.Trader.ExchangeHandler;
using TradingBot.Trader.TraderBuilder;
using ILogger = TradingBot.Logger.ILogger;

namespace TradingBot.Controllers;

[ApiController]
[Route("[controller]")]
public class IndicatorsController : ControllerBase
{
    private readonly ILogger _logger;
    private readonly List<ITrader> _traders;

    public IndicatorsController(ILogger logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public void Add()
    {
    }
}