/* Write a program that reads a list of words from 
 * a file words.txt and finds how many 
 * times each of the words is contained in another
 * file test.txt. The result should be written in the
 * file result.txt and the words should be sorted by 
 * the number of their occurrences in descending order.
 * Handle all possible exceptions in your methods.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace _13.CountWordsFromFile
{
    class CountWords
    {
        static void Main()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            try
            {
                using (StreamReader sr = new StreamReader("../../words.txt", Encoding.GetEncoding("utf-8")))
                {
                    while (!sr.EndOfStream)
                    {
                        string word = sr.ReadLine();
                        dictionary.Add(word, 0);
                    }
                }

                using (StreamReader sr = new StreamReader("../../test.txt", Encoding.GetEncoding("utf-8")))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        List<string> wordList = new List<string>(dictionary.Keys);

                        foreach (string word in wordList)
                        {
                            string regex = String.Format("\\b{0}\\b", word);
                            MatchCollection matches = Regex.Matches(line, regex);
                            dictionary[word] += matches.Count;
                        }
                    }
                }

                using (StreamWriter sw = new StreamWriter("../../result.txt", false, Encoding.GetEncoding("utf-8")))
                {
                    foreach (var wordCounter in dictionary.OrderByDescending(key => key.Value))
                    {
                        sw.WriteLine(wordCounter.Key + "->" + wordCounter.Value);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (RegexMatchTimeoutException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
