using TradingBot.Models.Enums;

namespace TradingBot.Trader.ExchangeHandler;

public interface IExchangeHandler
{
    //Returns the name of the exchange
    public string GetExchangeName();
    
    //Preform a trade on the exchange
    public Task<bool> Trade(TradeType tradeType, string ticker, decimal amount, decimal price, int? leverage);
}