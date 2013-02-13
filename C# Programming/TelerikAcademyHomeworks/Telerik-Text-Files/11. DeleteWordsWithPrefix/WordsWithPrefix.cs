/* Write a program that deletes from a text file all words that
 * start with the prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.
*/
namespace _11.DeleteWordsWithPrefix
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    class WordsWithPrefix
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();
            using (StreamReader sr = new StreamReader("../../input.txt"))
            {
                string line = sr.ReadLine();
                string pattern = "\\btest\\w*";
                while (line != null)
                {
                    Regex rgx = new Regex(pattern);
                    line = rgx.Replace(line, string.Empty);
                    myList.Add(line);
                    line = sr.ReadLine();
                }
            }

            using (StreamWriter sw = new StreamWriter("../../output.txt"))
            {
                for (int i = 0; i < myList.Count; i++)
                {
                    sw.WriteLine(myList[i]);
                }
            }
        }
    }
}
