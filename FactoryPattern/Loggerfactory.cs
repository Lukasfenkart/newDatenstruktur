using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal enum LoggerType
    {
        Console,
        File,
    }
    internal class Loggerfactory
    {
        public static ILogger CreateLogger(LoggerType type)
        {
            ILogger logger; 
            switch(type)
            {
                case LoggerType.Console:
                    logger = new ConsoleLogger();
                    break;
                case LoggerType.File:
                    logger = new FileLogger();
                    break;
                    default:
                    logger = new ConsoleLogger();
                    break;
            }
            return logger;
        }
    }
}
