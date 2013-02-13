/* Write a program that replaces all occurrences of
 * the substring "start" with the substring "finish" in
 * a text file. Ensure it will work with large files (e.g. 100 MB).
*/
namespace _07.ReplaceStartWithFinish
{
    using System;
    using System.IO;
    using System.Linq;

    class StartToFinish
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("../../output.txt"))
            {
                using (StreamReader sr = new StreamReader("../../input.txt"))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        line = line.Replace("start", "finish");
                        sw.WriteLine(line);
                        line = sr.ReadLine();
                    }
                }
            }
        }
    }
}
