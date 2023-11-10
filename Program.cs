using TradingBot.Logger;
using TradingBot.Trader;
using TradingBot.Trader.ExchangeHandler;
using ILogger = TradingBot.Logger.ILogger;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

ILogger logger = new ConsoleLogger();
IExchangeHandler exchangeHandler = new BinanceSocketHandler();

builder.Services.AddSingleton<ILogger>(logger);
//According to the configuration
builder.Services.AddSingleton<IExchangeHandler>(exchangeHandler);

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();