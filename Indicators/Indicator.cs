using TradingBot.Models;

namespace TradingBot.Indicators;

public class Indicator
{
    private readonly string _name;
    private readonly List<IndicatorEntry> _history;
    
    public Indicator(string name)
    {
        this._name = name;
        this._history = new List<IndicatorEntry>();
    }
    
    public string GetName()
    {
        return this._name;
    }

    public void AddEntry(IndicatorEntry entry)
    {
        this._history.Add(entry);
    }

    public List<IndicatorEntry> GetHistory()
    {
        return this._history;
    }
}