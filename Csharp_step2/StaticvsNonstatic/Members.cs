using System;

namespace StaticAndNonStaticMembers
{
    public static class EmployeeStaticLogger
    {
        public static int EmployeesList = 0;

        public static void LogMessage(string message)
        {
            Console.WriteLine($"[LOG] {message}");
            EmployeesList = EmployeesList + 1;
        }

        public static int GetMessageCount()
        {
            return EmployeesList;
        }
    }

    public class EmployeeNonStaticLogger
    {
        public int EmployeesList = 0;

        public void LogMessage(string message)
        {
            Console.WriteLine($"[LOG] {message}");
            EmployeesList = EmployeesList + 1;
        }

        public int GetMessageCount()
        {
            return EmployeesList;
        }
    }

    class Program
    {
        static void Main()
        {
            EmployeeStaticLogger.LogMessage("John has joined on 01-10-2021");
            EmployeeStaticLogger.LogMessage("Robert has joined on 01-11-2021");

            Console.WriteLine($"Total static log messages: {EmployeeStaticLogger.GetMessageCount()}");
        }
    }
}
