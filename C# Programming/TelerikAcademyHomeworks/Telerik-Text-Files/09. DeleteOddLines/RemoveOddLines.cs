// Write a program that deletes from given text file all odd lines. The result should be in the same file.

namespace _09.RemoveOddLines
{
    using System;
    using System.IO;
    using System.Text;

    class RemoveOddLines
    {
        static void Main()
        {

                using (StreamReader sr = new StreamReader("../../input.txt", Encoding.GetEncoding("utf-8")))
                {
                    using (StreamWriter sw = new StreamWriter("../../temp.txt", false, Encoding.GetEncoding("utf-8")))
                    {
                        int counter = 0;
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            if (counter % 2 == 0)
                            {
                                sw.WriteLine(line);
                            }
                            counter++;
                        }
                    }
                }
                File.Copy("../../temp.txt", "../../input.txt", true);
                File.Delete("../../temp.txt");
            
        }
    }
}