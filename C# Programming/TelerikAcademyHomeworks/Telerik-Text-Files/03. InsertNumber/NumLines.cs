// Write a program that reads a text file and inserts line numbers in front of each of its lines.
// The result should be written to another text file.

namespace _03.InsertNumber
{
    using System;
    using System.IO;
    using System.Linq;

    class NumLines
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("../../Output.txt"))
            {
                using (StreamReader sr = new StreamReader("../../File.txt"))
                {
                    int lineNumber = 0;
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        lineNumber++;
                        line = lineNumber + "->" + sr.ReadLine();
                        sw.WriteLine(line);
                        line = sr.ReadLine();
                    }
                }
            }
        }
    }
}
