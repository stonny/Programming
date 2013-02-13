/* Write a program that removes from a text file all
 * words listed in given another text file.
 * Handle all possible exceptions in your methods.
*/
namespace _12.RemoveWordsFromTextFile
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using System.Security;
    using System.Text;

    public class RemoveWords
    {

        public static void Main(string[] args)
        {
            try
            {
                List<string> words = ReadWordsToDelete();
                StringBuilder sb = new StringBuilder();
                sb.Append(@"\b(");
                foreach (string word in words) sb.Append(word + "|");
                sb.Remove(sb.Length - 1, 1);
                sb.Append(@")\b");
                string pattern = @sb.ToString();
                Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
                using (StreamWriter sw = new StreamWriter("../../output.txt"))
                {
                    using (StreamReader sr = new StreamReader("../../input.txt"))
                    {
                        string line = sr.ReadLine();
                        while (line != null)
                        {
                            string newLine = rgx.Replace(line, string.Empty);
                            sw.WriteLine(newLine);
                            line = sr.ReadLine();
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (SecurityException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static List<string> ReadWordsToDelete()
        {
            List<string> words = new List<string>();

            using (StreamReader reader = new StreamReader("../../words.txt"))
            {
                for (string line; (line = reader.ReadLine()) != null; ) words.Add(line);
            }

            return words;
        }
    }
}