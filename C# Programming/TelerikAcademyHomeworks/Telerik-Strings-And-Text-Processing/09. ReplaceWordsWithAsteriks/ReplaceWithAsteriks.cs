/* We are given a string containing a 
 * list of forbidden words and a text 
 * containing some of these words. 
 * Write a program that replaces the forbidden words with asterisks.
 * */
namespace _09.ReplaceWordsWithAsteriks
{
    using System;
    using System.Linq;

    class ReplaceWithAsteriks
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter text: ");
            string textToProcess = Console.ReadLine();
            Console.WriteLine("Forbid words(separate with ',')");
            string forbiddenWords = Console.ReadLine();
             * */
            string textToProcess = "Microsoft announced its next generation PHP compiler today."
            + "It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string forbiddenWords = "PHP,Microsoft,CLR";
            string[] forbidWords = forbiddenWords.Split(',');

            foreach (string word in forbidWords)
            {
                textToProcess = textToProcess.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(textToProcess);
        }
    }
}
