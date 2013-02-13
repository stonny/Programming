// Write a program that reads a text file and prints on the console its odd lines.

namespace _01.PrintTextFile
{
    using System;
    using System.Linq;
    using System.IO;
    class PrintTextFile
    {
        static void Main(string[] args)
        {
            using(StreamReader reader = new StreamReader("../../TextFile.txt"))
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while(line != null)
                {
                    if (lineNumber % 2 == 1)
                    {
                        Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    }
                    line = reader.ReadLine();
                    lineNumber++;
                }
            }
        }
    }
}
