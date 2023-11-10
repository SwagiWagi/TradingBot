using TradingBot.Models.Enums;

namespace TradingBot.ExchangeHandler;

public class BinanceSocketHandler : IExchangeHandler
{
    public string GetExchangeName()
    {
        return "Binance";
    }

    public Task<bool> Trade(TradeType tradeType, string ticker, decimal amount, decimal price, int? leverage)
    {
        throw new NotImplementedException();
    }
}