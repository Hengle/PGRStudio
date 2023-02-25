﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssetStudio
{
    public enum LoggerEvent
    {
        Verbose,
        Debug,
        Info,
        Warning,
        Error,
    }

    public interface ILogger
    {
        void Log(LoggerEvent loggerEvent, string message, bool silent);
    }

    public sealed class DummyLogger : ILogger
    {
        public void Log(LoggerEvent loggerEvent, string message, bool silent) { }
    }
    public sealed class ConsoleLogger : ILogger
    {
        public void Log(LoggerEvent loggerEvent, string message, bool silent)
        {
            Console.WriteLine("[{0}] {1}", loggerEvent, message);
        }
    }
}
