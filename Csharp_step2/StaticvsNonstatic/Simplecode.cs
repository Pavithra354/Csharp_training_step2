using System;

namespace SimpleCode
{
    class BasicCalculator
    {
        public static int number1 = 20;
        public static int number2 = 10;

        public static void Addition()
        {
            int sum = number1 + number2;
            Console.WriteLine($"Addition: {sum}");
        }

        public static void Multiplication()
        {
            int product = number1 * number2;
            Console.WriteLine($"Multiplication: {product}");
        }

        public void Subtraction()
        {
            int diff = number1 - number2;
            Console.WriteLine($"Subtraction: {diff}");
            Division();
        }

        public void Division()
        {
            if (number2 != 0)
            {
                int quotient = number1 / number2;
                Console.WriteLine($"Division: {quotient}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero!");
            }
        }

        class Program
        {
            static void Main()
            {
                Addition();
                Multiplication();

                BasicCalculator calc = new BasicCalculator();
                calc.Subtraction();
                calc.Division();
                
                Multiplication();
            }
        }
    }
}