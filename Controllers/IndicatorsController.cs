using Microsoft.AspNetCore.Mvc;
using TradingBot.ExchangeHandler;
using TradingBot.Models;
using ILogger = TradingBot.Logger.ILogger;

namespace TradingBot.Controllers;

[ApiController]
[Route("[controller]")]
public class IndicatorsController : ControllerBase
{
    private readonly ILogger _logger;
    private readonly IExchangeHandler _exchangeHandler;
    
    private readonly Dictionary<string, Trader> _traders;

    public IndicatorsController(ILogger logger, IExchangeHandler exchangeHandler)
    {
        _logger = logger;
        _exchangeHandler = exchangeHandler;
    }

    [HttpPost]
    public Task Add(IndicatorAlert indicatorAlert)
    {
        _logger.IndicatorAlert(indicatorAlert);

        if (!this._traders.ContainsKey(indicatorAlert.Ticker))
        {
            TraderBuilder traderBuilder = new TraderBuilder()
                .SetLogger(_logger)
                .SetExchangeHandler(this._exchangeHandler)
                .SetTicker(indicatorAlert.Ticker);
            
            _traders.Add(indicatorAlert.Ticker, traderBuilder.Build());
        }

        _traders[indicatorAlert.Ticker].AddIndicatorAlert(indicatorAlert);
        
        return Task.CompletedTask;
    }
}