using System;

namespace SchoolExample
{
    public class School
    {
        // Static members - common for the entire class
        public static string SchoolName = "Green Valley High School";
        public static string Principal = "Mrs. Smith";

        public static void ShowSchoolInfo()
        {
            Console.WriteLine($"School Name: {School.SchoolName}");
            Console.WriteLine($"Principal: {Principal}");
        }

        // Non-static members - unique for each object
        public string StudentName { get; set; }
        public int RollNumber { get; set; }

        public School(string studentName, int rollNumber)
        {
            this.StudentName = studentName;
            this.RollNumber = rollNumber;
        }

        public void ShowStudentInfo()
        {
            Console.WriteLine($"Student Name: {this.StudentName}");
            Console.WriteLine($"Roll Number: {RollNumber}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Call static members directly using class name
            Console.WriteLine("Static Members:");
            School.ShowSchoolInfo();

            // Call non-static members using object instance
            Console.WriteLine("\nNon-Static Members:");
            School student1 = new School("Alice", 101);
            student1.ShowStudentInfo();

            School student2 = new School("Bob", 102);
            student2.ShowStudentInfo();
        }
    }
}

