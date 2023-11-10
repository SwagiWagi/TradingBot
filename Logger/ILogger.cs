using TradingBot.Models;
using TradingBot.Models.Enums;

namespace TradingBot.Logger;

public interface ILogger
{
    public Task<bool> Debug(string message);
    public Task<bool> Log(string message);
    public Task<bool> Trade(
        TradeType tradeType,
        string exchangeName,
        string ticker,
        decimal amount,
        decimal price,
        decimal fee);
    public Task<bool> Error(string message);
    public Task<bool> Critical(string message);
    
    public Task<bool> IndicatorAlert(IndicatorAlert indicatorAlert);
}