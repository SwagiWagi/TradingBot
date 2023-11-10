using TradingBot.ExchangeHandler;
using TradingBot.Indicators;
using TradingBot.Models;
using ILogger = TradingBot.Logger.ILogger;

namespace TradingBot;

public class Trader
{
    private readonly ILogger _logger;
    private readonly IExchangeHandler _exchangeHandler;
    
    private readonly string _ticker;

    private readonly Dictionary<string, Indicator> _indicators;

    public Trader(ILogger logger, IExchangeHandler exchangeHandler, string ticker)
    {
        this._logger = logger;
        this._exchangeHandler = exchangeHandler;
        
        this._ticker = ticker;

        this._indicators = new Dictionary<string, Indicator>();
    }
    
    public void AddIndicatorAlert(IndicatorAlert indicatorAlert)
    {
    }
}