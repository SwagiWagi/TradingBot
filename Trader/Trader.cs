using TradingBot.Models;
using TradingBot.Trader.ExchangeHandler;
using TradingBot.Trader.Indicators;
using ILogger = TradingBot.Logger.ILogger;

namespace TradingBot.Trader;

public class Trader
{
    private readonly ILogger _logger;
    private readonly IExchangeHandler _exchangeHandler;
    
    private readonly string _ticker;
    private readonly string _timeframe;

    private readonly Dictionary<string, Indicator> _indicators;

    public Trader(ILogger logger, IExchangeHandler exchangeHandler, string ticker, string timeframe)
    {
        this._logger = logger;
        this._exchangeHandler = exchangeHandler;
        
        this._ticker = ticker;
        this._timeframe = timeframe;

        this._indicators = new Dictionary<string, Indicator>();
    }
    
    public void AddIndicatorAlert(IndicatorAlert indicatorAlert)
    {
    }
}