// Modify the solution of the previous problem to replace only whole words (not substrings).

namespace _08.ModifiedStartWithFinish
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Text.RegularExpressions;

    class ModifiedStartWithFinish
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
                        sw.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
                        line = sr.ReadLine();
                    }
                }
            }
        }
    }
}
