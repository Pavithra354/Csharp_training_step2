using System;

namespace CompanyExample
{
    class CEO
    {
        public string Name { get; set; }

        public CEO()
        {
            Name = "Mr. Johnson";
            Console.WriteLine($"CEO's name is: {Name}");
        }

        public CEO(string ceoName)
        {
            Name = ceoName;
            Console.WriteLine($"CEO's name (parameterized): {Name}");
        }

        public void Announce()
        {
            Console.WriteLine($"Hello, I am {Name}, the CEO.");
        }
    }

    class Manager : CEO
    {
        public string Department { get; set; }

        public Manager() : base()
        {
            Department = "General Management";
            Console.WriteLine($"Department: {Department}");
        }

        public Manager(string ceoName, string dept) : base(ceoName)
        {
            Department = dept;
            Console.WriteLine($"Manager works in: {Department}");
        }

        public void ManageTeam()
        {
            Console.WriteLine($"I manage the {Department} department.");
        }
    }

    class Employee : Manager
    {
        public Employee()
        {
            Console.WriteLine("Employee created.");
        }

        public Employee(string ceoName, string dept) : base(ceoName, dept)
        {
            Console.WriteLine("Employee created with CEO and Department details.");
        }

        public string[] TeamMates()
        {
            return new string[] { "Alice", "Bob" };
        }
    }

    class Program
    {
        static void Main()
        {
            // Using default constructors
            Console.WriteLine("=== Example 1: Default ===");
            Employee emp1 = new Employee();
            emp1.TeamMates();
            emp1.Announce();   // From CEO
            emp1.ManageTeam(); // From Manager

            // Using parameterized constructors
            Console.WriteLine("\n=== Example 2: Parameterized ===");
            Employee emp2 = new Employee("Mrs. Olivia", "Sales");
            emp2.TeamMates();
            emp2.Announce();
            emp2.ManageTeam();
        }
    }
}