using System;
using System.IO;
using BaiTap1.Models;
namespace BaiTap1.Utils
{
    public class Logger : ILogger
    {
        private readonly string logFilePath = "application.log";

        public void Log(string message)
        {
            File.AppendAllText(logFilePath, $"{DateTime.Now}: {message}{Environment.NewLine}");
        }

        public void LogInfo(string message)
        {
            Log($"INFO: {message}");
        }

        public void LogError(string message)
        {
            Log($"ERROR: {message}");
        }
    }
}