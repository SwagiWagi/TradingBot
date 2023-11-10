using TradingBot.ExchangeHandler;
using ILogger = TradingBot.Logger.ILogger;

namespace TradingBot.Trader;

public abstract class ITrader
{
    private readonly ILogger _logger;
    private readonly IExchangeHandler _exchangeHandler;
    
    private readonly string _ticker;
    private readonly string _timeframe;

    private readonly Dictionary<string, bool> _indicators;

    protected ITrader(ILogger logger, IExchangeHandler exchangeHandler, string ticker, string timeframe)
    {
        this._logger = logger;
        this._exchangeHandler = exchangeHandler;
        
        this._ticker = ticker;
        this._timeframe = timeframe;

        this._indicators = new Dictionary<string, bool>();
    }
    
    public abstract Task Run();
}