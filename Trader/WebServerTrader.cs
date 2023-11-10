using TradingBot.Trader.ExchangeHandler;
using ILogger = TradingBot.Logger.ILogger;

namespace TradingBot.Trader;

public class WebServerTrader : ITrader
{
    private readonly int _port;

    public WebServerTrader(int port, ILogger logger, IExchangeHandler exchangeHandler, string ticker, string timeframe) : base(logger, exchangeHandler, ticker, timeframe)
    {
        this._port = port;
    }
}