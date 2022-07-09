using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerExclusive
{
    internal class ConsoleLogger
    {

        public void DefaultLog(string message)
        {
            Console.WriteLine(TimeNow() + message);
        }
        public void ImportantLog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(TimeNow() + message);
            Console.ForegroundColor= ConsoleColor.White;
        }


        public string TimeNow()
        {
            return $"[{TwoDigitTime(DateTime.Now.Hour.ToString())}:{TwoDigitTime(DateTime.Now.Minute.ToString())}:{TwoDigitTime(DateTime.Now.Second.ToString())}]\t";
        }

        private string TwoDigitTime(string timeToString)
        {
            if (timeToString.Length == 1) return "0" + timeToString;
            else return timeToString;
        }




    }
}
