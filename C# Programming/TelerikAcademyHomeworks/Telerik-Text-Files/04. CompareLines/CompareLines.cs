/* Write a program that compares two text files line by line
 * and prints the number of lines that are the same and the number 
 * of lines that are different. Assume the files have equal number of lines.
*/
namespace _04.CompareLines
{
    using System;
    using System.IO;
    using System.Linq;

    class CompareLines
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("../../FirstFile.txt"))
            {
                using (StreamReader sr2 = new StreamReader("../../SecondFile.txt"))
                {
                    int equalLines = 0;
                    int differentLines = 0;
                    string firstFileLine = string.Empty;
                    while(firstFileLine != null)
                    {
                        
                        firstFileLine = sr.ReadLine();
                        string secondFileLine = sr2.ReadLine();
                        if (firstFileLine == secondFileLine)
                        {
                            equalLines++;
                        }
                        else
                        {
                            differentLines++;
                        }
                    }
                    Console.WriteLine("Equal lines:{0} \r\nDifferent Lines:{1}", equalLines, differentLines);
                }
            }

        }
    }
}