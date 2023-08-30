using System.Runtime.CompilerServices;

namespace SimpleUtil;

public sealed class Logger
{
    private readonly bool logToConsole;
    private readonly string? logFilePath;

    public Logger(bool logToConsole = true, string? logFilePath = null)
    {
        this.logToConsole = logToConsole;
        this.logFilePath = logFilePath;
    }

    private void LogToConsole(string message)
    {
        if (logToConsole)
            Console.WriteLine(message);
    }

    private void LogToFile(string message)
    {
        if (logFilePath != null)
            File.AppendAllText(logFilePath, $"{message}\n");
    }

    public void Log(string message)
    {
        LogToConsole(message);
        LogToFile(message);
    }
}
