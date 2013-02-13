using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary[".NET"] = "platform for applications from Microsoft";
            dictionary["CLR"] = "managed execution environment for .NET";
            dictionary["namespace"] = "hierarchical organization of classes";

            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            if (dictionary.ContainsKey(word))
            {
                Console.WriteLine("{0} - {1} ", word, dictionary[word]);
            }
            else
            {
                Console.WriteLine("Dictionary doesn't contain the word \"{0}\" ", word);
            }
        }
    }
}
