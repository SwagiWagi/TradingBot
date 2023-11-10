using TradingBot.Models;
using TradingBot.Models.Enums;

namespace TradingBot.Logger;

public class ConsoleLogger : ILogger
{
    public ConsoleLogger()
    {
    }
    
    public async Task<bool> Debug(string message)
    {
        Console.WriteLine($"[DEBUG] {message}");
        return true;
    }
    
    public async Task<bool> Log(string message)
    {
        Console.WriteLine($"[LOG] {message}");
        return true;
    }
    
    public async Task<bool> Trade(
        TradeType tradeType,
        string exchangeName,
        string ticker,
        decimal amount,
        decimal price,
        decimal fee)
    {
        Console.WriteLine($"[TRADE] {tradeType} {exchangeName} {ticker} {amount} {price} {fee}");
        return true;
    }
    
    public async Task<bool> Error(string message)
    {
        Console.WriteLine($"[ERROR] {message}");
        return true;
    }
    
    public async Task<bool> Critical(string message)
    {
        Console.WriteLine($"[FATAL] {message}");
        return true;
    }

    public async Task<bool> IndicatorAlert(IndicatorAlert indicatorAlert)
    {
        Console.WriteLine($"[INDICATOR ALERT] {indicatorAlert}");
        return true;
    }
}