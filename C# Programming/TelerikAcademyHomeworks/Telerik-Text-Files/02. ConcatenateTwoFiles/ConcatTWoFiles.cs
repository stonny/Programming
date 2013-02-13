// Write a program that concatenates two text files into another text file.
namespace _02.ConcatenateTwoFiles
{
    using System;
    using System.IO;
    using System.Linq;

    class ConcatTWoFiles
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("../../Output.txt"))
            {
                using (StreamReader sr = new StreamReader("../../FirstFile.txt"))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        sw.WriteLine(line);
                        line = sr.ReadLine();
                    }
                }
                using (StreamReader sr = new StreamReader("../../SecondFile.txt"))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        sw.WriteLine(line);
                        line = sr.ReadLine();
                    }
                }
            }
        }
    }
}
