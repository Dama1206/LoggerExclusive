using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoggerExclusive
{
    internal class PathLogger
    {
        private StreamWriter streamWriter;
        public enum DataTypes
        {
            TXT,
            
        }

        public void SetLogpath(string path, DataTypes dataType)
        {
            streamWriter = new StreamWriter(PathController(path, dataType), true);
        }
        public void DefaultLog(string message)
        {
            streamWriter.WriteLine(TimeNow() + message);
        }
        public void ImportantLog(string message)
        {
            streamWriter.WriteLine("!**" + TimeNow() + message);

        }


        public string TimeNow()
        {
            return $"[{TwoDigitTime(DateTime.Now.Hour.ToString())}:{TwoDigitTime(DateTime.Now.Minute.ToString())}:{TwoDigitTime(DateTime.Now.Second.ToString())}]\t";
        }

        private string TwoDigitTime(string timeToString)
        {
            if(timeToString.Length ==1) return "0" + timeToString;
            else return timeToString;
        }

        private string PathController(string defPath, DataTypes dataType)
        {
            bool inheritsPoint = false;
            for(int i = 0; i < defPath.Length; i++)
            {
                if (defPath[i] == '.') inheritsPoint = true;
                
            }
            if (inheritsPoint) { return defPath; }
            else return defPath + "." + dataType.ToString().ToLower();
        }

        public void CloseLogger()
        {
            streamWriter.Close();
        }

    }
}
