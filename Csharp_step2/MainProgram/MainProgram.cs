//using ExcelFilesSystem;
using PPTFileSystem;
//using WordFilesSystem;


using System;

namespace MainProgramSystem
{
    class MainProgram
    {
        public static void Main()
        {
            //ExcelFilesSystem.Jan_File janfile1 = new ExcelFilesSystem.Jan_File();
            ////Console.WriteLine(janfile1.FileName);


            PPTFileSystem.Jan_File janfile = new PPTFileSystem.Jan_File();
            ////Console.WriteLine(janfile.FileName);

            //WordFilesSystem.Jan_File jan_File = new WordFilesSystem.Jan_File();

            Feb_File febfile = new Feb_File();
            Console.WriteLine(febfile.FileName);

            Mar_File mar_File = new Mar_File();
            Console.WriteLine(mar_File.FileName);

        }
    }
}