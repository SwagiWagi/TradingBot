using TradingBot.ExchangeHandler;
using ILogger = TradingBot.Logger.ILogger;

namespace TradingBot.Trader;

public class SocketTrader : ITrader
{
    private readonly int _port;
    
    public SocketTrader(int port, ILogger logger, IExchangeHandler exchangeHandler, string ticker, string timeframe) : base(logger, exchangeHandler, ticker, timeframe)
    {
        this._port = port;
    }

    public override Task Run()
    {
        throw new NotImplementedException();
    }
}