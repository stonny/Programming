/* Write a program that reads a list of words, separated by 
 * spaces and prints the list in an alphabetical order.
*/

namespace _24.SortListOfWords
{
    using System;
    using System.Linq;

    class SortListOfWOrds
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] textToProcess = text.Split(' ');
            Array.Sort(textToProcess);
            foreach (string word in textToProcess)
            {
                Console.WriteLine(word);
            }
        }
    }
}
