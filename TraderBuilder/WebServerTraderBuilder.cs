using TradingBot.Trader;

namespace TradingBot.TraderBuilder;

public class WebServerTraderBuilder : ITraderBuilder
{
    public override ITrader Build()
    {
        return new WebServerTrader(this._port, this._logger, this._exchangeHandler, this._ticker, this._timeframe);
    }
}