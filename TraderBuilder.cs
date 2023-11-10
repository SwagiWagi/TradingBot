using TradingBot.ExchangeHandler;
using ILogger = TradingBot.Logger.ILogger;

namespace TradingBot;

public class TraderBuilder
{
    private ILogger _logger;
    private IExchangeHandler _exchangeHandler;

    private string _ticker;

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

    public Trader Build()
    {
        return new Trader(this._logger, this._exchangeHandler, this._ticker);
    }
}