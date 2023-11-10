using TradingBot.Models.Enums;

namespace TradingBot.Models;

public struct IndicatorEntry
{
    public TradeType TradeType { get; init; }
    public string TimeStamp { get; init; }
    public decimal Price { get; init; }
    public decimal Amount { get; init; }
    public decimal Leverage { get; init; }
    public decimal Fee { get; init; }
}