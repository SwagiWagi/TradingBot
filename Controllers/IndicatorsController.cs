using Microsoft.AspNetCore.Mvc;
using TradingBot.Models;
using TradingBot.Trader;
using TradingBot.Trader.ExchangeHandler;
using ILogger = TradingBot.Logger.ILogger;

namespace TradingBot.Controllers;

[ApiController]
[Route("[controller]")]
public class IndicatorsController : ControllerBase
{
    private readonly ILogger _logger;
    private readonly IExchangeHandler _exchangeHandler;
    
    private readonly Dictionary<string, Trader.Trader> _traders;

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
            var trader = new TraderBuilder()
                .SetLogger(_logger)
                .SetExchangeHandler(this._exchangeHandler)
                .SetTicker(indicatorAlert.Ticker)
                .SetTimeframe(indicatorAlert.TimeFrame)
                .Build();
            
            _traders.Add(indicatorAlert.Ticker, trader);
        }
        
        _traders[indicatorAlert.Ticker].AddIndicatorAlert(indicatorAlert);
        
        return Task.CompletedTask;
    }
}