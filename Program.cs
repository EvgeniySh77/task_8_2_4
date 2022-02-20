using System;
using System.IO;

namespace task_8_2_4
{
    class Program
    {
        static void Main()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\INTENSO\Desktop\Techno");
            string newPath = @"C:\$Recycle.Bin\Techno";

            dirInfo.MoveTo(newPath);
        }
    }
}
