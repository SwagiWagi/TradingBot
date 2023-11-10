using TradingBot.ExchangeHandler;
using ILogger = TradingBot.Logger.ILogger;

namespace TradingBot.Trader;

public class WebServerTrader : ITrader
{
    private readonly int _port;

    public WebServerTrader(int port, ILogger logger, IExchangeHandler exchangeHandler, string ticker, string timeframe) : base(logger, exchangeHandler, ticker, timeframe)
    {
        this._port = port;
    }

    public override Task Run()
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Hello World!");

        app.Run();
    }
    
    private async Task DefaultRoute(HttpContext ctx)
    {
        await ctx.Response.Send("Hello world!");
    }
}