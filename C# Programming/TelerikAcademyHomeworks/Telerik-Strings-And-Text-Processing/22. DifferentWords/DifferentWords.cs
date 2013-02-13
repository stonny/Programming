/*Write a program that reads a string from the 
 * console and lists all different words in the string 
 * along with information how many times each word is found.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _22.DifferentWords
{
    class DifferentWords
    {
        static Dictionary<string, int> WordsCount(string text)
        {
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            MatchCollection words = Regex.Matches(text, @"\b\w+\b");
            foreach (Match word in words)
            {
                if (wordsCount.ContainsKey(word.ToString()))
                {
                    wordsCount[word.ToString()]++;
                }
                else
                {
                    wordsCount[word.ToString()] = 1;
                }
            }
            return wordsCount;
        }
        static void Main(string[] args)
        {
            Console.Write("Input a text: ");
            Dictionary<string, int> wordsCount = WordsCount(Console.ReadLine());
            foreach (string key in wordsCount.Keys)
            {
                Console.WriteLine("{0} - {1} times", key, wordsCount[key]);
            }
        }
    }
}
