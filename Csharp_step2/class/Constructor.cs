using System;

/// <summary>
/// Constructor is a special method that is used to initialize objects.
/// It is called when an instance of the class is created.
/// </summary>
class FileDetailsConstructors
{
    string filename = "Student1_Resume.docx";
    string filelocation = @"D:\Students\Resumes";
    string filesize = "2Kb";
    string createddate = "Mar-01-2024";
    DateTime createdDateTime = DateTime.Now;

    // Default constructor
    public FileDetailsConstructors()
    {
        Console.WriteLine("File object created");

        this.filename = "Employee1_Salary.pdf";
        this.filelocation = @"C:\Employees\Salaries";
        this.filesize = "1Kb";
        this.createddate = "Jan-01-2025";
        this.createdDateTime = DateTime.Now;

        Console.WriteLine(this.filename);
        Console.WriteLine(this.filelocation);
        Console.WriteLine(this.filesize);
        Console.WriteLine(this.createddate);
    }

    // Parameterized constructor
    public FileDetailsConstructors(string filename, string filelocation, string filesize, string createddate)
    {
        Console.WriteLine("File object created");

        this.filename = filename;
        this.filelocation = filelocation;
        this.filesize = filesize;
        this.createddate = createddate;
        this.createdDateTime = DateTime.Now;

        Console.WriteLine(this.filename);
        Console.WriteLine(this.filelocation);
        Console.WriteLine(this.filesize);
        Console.WriteLine(this.createddate);
    }

    static void Main()
    {
        FileDetailsConstructors fileDetailsConstructors1 = new FileDetailsConstructors();
        FileDetailsConstructors fileDetailsConstructors2 =
            new FileDetailsConstructors("CreditCardStatementMarch.pdf", @"C:\", "5Kb", "1-Mar-2025");
    }
}