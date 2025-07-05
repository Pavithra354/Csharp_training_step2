
using System;

static class Logger
{
    //Fields
    static string logfile = "application1.txt";
    static string logFileDescription = "You have logged in the App At July-07-2025 at 9:07PM";
    static string LogFile { get; set; }

    static Logger()
    {
        Logger.LogFile = "application2.txt";
    }

    static void LogMessage(string Level, string Message)
    {
        Console.WriteLine($"{DateTime.Now} [{Level} - {Message}]");
    }

    static void LogInfo(string Message)
    {
        Logger.LogMessage("INFO", Message);
    }

    static void LogWarning(string Message)
    {
        Logger.LogMessage("Warning", Message);
    }

    static void LogError(string Message)
    {
        Logger.LogMessage("Error", Message);
    }

    static void Main()
    {
        string str1 = Logger.logfile;
        string str2 = Logger.logFileDescription;
        // Console.WriteLine($"Log file name is {Logger.logfile}");
        //  Console.WriteLine($"Log file name is {Logger.logFileDescription}");

        Logger.LogInfo("Application started");
        Logger.LogWarning("You have entered the wrong password three times. If you enter it incorrectly again, your account will be locked for at least one hour");
        Logger.LogError("Something is Wrong...Please try again after sometime.");


        Logger.LogInfo("Application stopped.");

    }



}