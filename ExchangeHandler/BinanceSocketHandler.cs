using TradingBot.Models.Enums;

namespace TradingBot.ExchangeHandler;

public class BinanceSocketHandler : IExchangeHandler
{
    private const string _exchangeName = "Binance";
    
    private string _ticker;
    
    public string GetExchangeName()
    {
        return BinanceSocketHandler._exchangeName;
    }

    public Task<bool> Trade(TradeType tradeType, string ticker, decimal amount, decimal price, int? leverage)
    {
        throw new NotImplementedException();
    }
}