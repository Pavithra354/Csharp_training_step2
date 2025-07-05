using System;

namespace StaticAndNonStaticInstatiate
{
    public static class StaticClass
    {
        public static void PrintMessage()
        {
            Console.WriteLine("This is a static class method.");
        }
    }

    public class NonStaticClass
    {
        public void PrintMessage()
        {
            Console.WriteLine("This is a non-static class method.");
        }

        public static void PrintMessage2()
        {
            Console.WriteLine("This is a non-static class method and Static Method");
        }

    }

    public class Program
    {
        public static void Main()
        {
            StaticClass.PrintMessage();

            NonStaticClass nonStaticClass = new NonStaticClass();
            nonStaticClass.PrintMessage();

            NonStaticClass.PrintMessage2();

        }
    }
}