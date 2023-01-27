using FactoryPattern;

DateTime lastlog = DateTime.Now;
var logType = "Console";

while (true)
{
    if(lastlog < DateTime.Now)
    {
        var result = $"ein Auto wurde produziert um {DateTime.Now}";
        var logger = Loggerfactory.CreateLogger(LoggerType.Console);
        Log(result, logger);
        lastlog = DateTime.Now.AddSeconds(0.5);
    }
}

void Log(string result, ILogger logger)
{
    logger.Log(result);
}