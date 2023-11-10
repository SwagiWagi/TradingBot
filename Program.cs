using TradingBot.ExchangeHandler;
using TradingBot.Logger;
using TradingBot.Trader;
using TradingBot.TraderBuilder;
using ILogger = TradingBot.Logger.ILogger;

//Init custom services
ILogger logger = new ConsoleLogger();

ITraderBuilder traderBuilder = new WebServerTraderBuilder();

ITrader btcUsdtTrader = traderBuilder
    .SetLogger(logger)
    .SetExchangeHandler(new BinanceSocketHandler())
    .SetTicker("BTCUSDT")
    .Build();


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddSingleton<ILogger>(logger);
builder.Services.AddSingleton<ITrader>(btcUsdtTrader);


var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();