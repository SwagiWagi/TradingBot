using TradingBot.Models.Enums;

namespace TradingBot.Trader.ExchangeHandler;

public class BinanceSocketHandler : IExchangeHandler
{
    private string _ticker;
    
    public string GetExchangeName()
    {
        return "Binance";
    }

    public Task<bool> Trade(TradeType tradeType, string ticker, decimal amount, decimal price, int? leverage)
    {
        throw new NotImplementedException();
    }
}