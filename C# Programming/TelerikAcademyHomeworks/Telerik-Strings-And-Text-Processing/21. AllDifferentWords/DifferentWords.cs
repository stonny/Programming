/* Write a program that reads a string from the 
 * console and prints all different letters in the 
 * string along with information how many times each letter is found. 
*/
namespace _21.AllDifferentWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class DifferentWords
    {
        static Dictionary<char, int> LettersCount(string text)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();
            foreach (char letter in text)
            {
                if (letters.ContainsKey(letter))
                {
                    letters[letter]++;
                }
                else
                {
                    letters[letter] = 1;
                }
            }
            return letters;
        }
        static void Main(string[] args)
        {
            Console.Write("Input a text: ");
            Dictionary<char, int> lettersCount = LettersCount(Console.ReadLine());
            foreach (char key in lettersCount.Keys)
            {
                Console.WriteLine("{0} -> {1} times", key, lettersCount[key]);
            }
        }
    }
}
