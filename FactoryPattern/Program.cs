using FactoryPattern;

DateTime lastlog = DateTime.Now;
var logType = "Console";
var counter = 1;

while (true)
{
    if(lastlog < DateTime.Now)
    {
        
        if(counter == 1 || counter == 7 || counter == 9)
        {
            var result = $"ein VW Polo wurde produziert um {DateTime.Now}";
            var logger = Loggerfactory.CreateLogger(LoggerType.Console);
            Log(result, logger);
            lastlog = DateTime.Now.AddSeconds(0.5);
        }
        else if (counter == 2 || counter == 3 || counter == 5)
        {
            var result = $"ein Porsche 911 wurde produziert um {DateTime.Now}";
            var logger = Loggerfactory.CreateLogger(LoggerType.Console);
            Log(result, logger);
            lastlog = DateTime.Now.AddSeconds(0.5);
        }
        else if (counter == 4 || counter == 6 || counter == 8)
        {
            var result = $"ein Toyota Prius wurde produziert um {DateTime.Now}";
            var logger = Loggerfactory.CreateLogger(LoggerType.Console);
            Log(result, logger);
            lastlog = DateTime.Now.AddSeconds(0.5);
        }
        counter++;
        if (counter == 10)
        { counter = 0; }
    }
    
}

void Log(string result, ILogger logger)
{
    logger.Log(result);
    
}