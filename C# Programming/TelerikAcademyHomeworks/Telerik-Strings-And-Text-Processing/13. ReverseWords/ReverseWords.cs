/* Write a program that reverses the words in given sentence.
	Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".
*/

namespace _13.ReverseWords
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class ReverseWords
    {
        static string Reverse(string sentence)
        {
            string[] words = sentence.Split(' ', '.', '!', '?', ',');
            Array.Reverse(words);
            MatchCollection match = Regex.Matches(sentence, @"\s+|,\s*|\.\s*|!\s*");
            StringBuilder builder = new StringBuilder();
            int nextSymbol = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (!String.IsNullOrEmpty(words[i]))
                {
                    builder.Append(words[i]);
                    if (nextSymbol < match.Count)
                    {
                        builder.Append(match[nextSymbol]);
                        nextSymbol++;
                    }
                }
            }

            return builder.ToString().Trim();
        }
        static void Main(string[] args)
        {
            string sentence = "C# is not C++, not PHP and not Delphi!";
            Console.WriteLine(Reverse(sentence));
        }
    }
}
