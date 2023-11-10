namespace TradingBot.Trader.TraderBuilder;

public class SocketTraderBuilder : ITraderBuilder
{
    public override ITrader Build()
    {
        return new SocketTrader(this._port, this._logger, this._exchangeHandler, this._ticker, this._timeframe);
    }
}