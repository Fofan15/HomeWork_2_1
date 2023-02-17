using System;
using System.IO;


namespace CodeHomework_2_1
{
    public class Logger
    {
        public string MessageError { get; private set; }
        public string MessageInfo { get; private set; }
        public string MessageWarning { get; private set; }

        public Logger() 
        {
            MessageError = "";
            MessageInfo = "";
            MessageWarning = "";
        }

        public void LogError(string message)
        {
            MessageError += message + " ";
        }

        public void LogInfo(string message)
        {
            MessageInfo += message + " ";
        }
        public void LogWarning(string message)
        {
            MessageWarning += message + " ";
        }

        public void Log(string type, string message) 
        {
            Console.WriteLine($"{DateTime.Now}: {type}: {message}");
        }

        public void LogTxt() 
        {
            File.WriteAllText("log.txt", MessageError);
            File.WriteAllText("log.txt", MessageInfo);
            File.WriteAllText("log.txt", MessageWarning);
        }
    }
}
