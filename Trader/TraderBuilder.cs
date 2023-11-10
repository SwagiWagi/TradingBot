using TradingBot.Trader.ExchangeHandler;
using ILogger = TradingBot.Logger.ILogger;

namespace TradingBot.Trader;

public class TraderBuilder
{
    private ILogger _logger;
    private IExchangeHandler _exchangeHandler;

    private string _ticker;
    private string _timeframe;

    public TraderBuilder()
    {
    }
    
    public TraderBuilder SetLogger(ILogger logger)
    {
        this._logger = logger;
        return this;
    }
    
    public TraderBuilder SetExchangeHandler(IExchangeHandler exchangeHandler)
    {
        this._exchangeHandler = exchangeHandler;
        return this;
    }
    
    public TraderBuilder SetTicker(string ticker)
    {
        this._ticker = ticker;
        return this;
    }

    public TraderBuilder SetTimeframe(string timeframe)
    {
        this._timeframe = timeframe;
        return this;
    }

    public Trader Build()
    {
        return new Trader(this._logger, this._exchangeHandler, this._ticker, this._timeframe);
    }
}