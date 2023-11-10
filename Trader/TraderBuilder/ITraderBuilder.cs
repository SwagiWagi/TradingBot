using TradingBot.Trader.ExchangeHandler;
using ILogger = TradingBot.Logger.ILogger;

namespace TradingBot.Trader.TraderBuilder;

public abstract class ITraderBuilder
{
    protected int _port;
    
    protected ILogger _logger;
    protected IExchangeHandler _exchangeHandler;

    protected string _ticker;
    protected string _timeframe;

    protected ITraderBuilder()
    {
    }
    
    protected ITraderBuilder SetPort(int port)
    {
        this._port = port;
        return this;
    }
    
    public ITraderBuilder SetLogger(ILogger logger)
    {
        this._logger = logger;
        return this;
    }
    
    public ITraderBuilder SetExchangeHandler(IExchangeHandler exchangeHandler)
    {
        this._exchangeHandler = exchangeHandler;
        return this;
    }
    
    public ITraderBuilder SetTicker(string ticker)
    {
        this._ticker = ticker;
        return this;
    }

    public ITraderBuilder SetTimeframe(string timeframe)
    {
        this._timeframe = timeframe;
        return this;
    }

    public abstract ITrader Build();
}