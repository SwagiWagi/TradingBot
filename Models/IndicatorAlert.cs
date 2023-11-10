using TradingBot.Models.Enums;

namespace TradingBot.Models;

public struct IndicatorAlert
{
    public string Ticker { get; init; }
    public string TimeFrame { get; init; }
    public TradeType TradeType { get; init; }
    public string TimeStamp { get; init; }
    public decimal Price { get; init; }
}