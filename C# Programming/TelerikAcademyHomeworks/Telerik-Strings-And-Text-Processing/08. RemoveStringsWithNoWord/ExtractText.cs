// Write a program that extracts from a given text all sentences containing given word.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.RemoveStringsWithNoWord
{
    class ExtractText
    {
        static void Main(string[] args)
        {
             // string textToProcess = "We are living in a yellow submarine. We don't have anything else." +
             // " Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
             // string word = "in";
            Console.WriteLine("Enter text:");
            string textToProcess = Console.ReadLine();
            Console.WriteLine("Enter word:");
            string word = Console.ReadLine();
            
            string[] parts = textToProcess.Split('.');
            foreach (string sentece in parts)
            {
                if (Regex.Match(sentece, "\\b" + word + "\\b") != Match.Empty)
                {
                    Console.WriteLine((sentece + ".").Trim());
                }
            }
        }
    }
}
