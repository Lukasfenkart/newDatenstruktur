using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"DateTime: {DateTime.Now}, Data: {message}"); ;
        }
    }
    internal class FileLogger : ILogger
    {
        public void Log(string message)
        {
            using (StreamWriter w = File.AppendText("performanceData.log"))
                w.WriteLine($"DateTime: {DateTime.Now}, Data: {message}");
        }
    }
}
