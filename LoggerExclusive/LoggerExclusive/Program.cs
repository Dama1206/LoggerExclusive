using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerExclusive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger consoleLogger = new ConsoleLogger();
            consoleLogger.DefaultLog("DefLog");
            consoleLogger.ImportantLog("ImportantLog");
            Console.ReadLine();
        }
        private static void PathLoggerText()
        {
            PathLogger pathLogger = new PathLogger();
            pathLogger.SetLogpath("Test", PathLogger.DataTypes.TXT);
            pathLogger.DefaultLog("DefLog");
            pathLogger.ImportantLog("ImportantLog");
            pathLogger.CloseLogger();
        }
    }
}
