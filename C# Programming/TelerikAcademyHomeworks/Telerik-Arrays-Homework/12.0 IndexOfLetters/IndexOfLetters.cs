/* Write a program that creates an array containing 
 * all letters from the alphabet (A-Z). 
 * Read a word from the console and print
 * the index of each of its letters in the array.
*/
namespace _12._0_IndexOfLetters
{
    using System;
    using System.Linq;

   public class IndexOfLetters
    {
      public static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] myArray = new char[26];
            for (int i = 0; i < 26; i++)
            {
                myArray[i] = Convert.ToChar('a' + i);
            }

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine("{0} -> {1}", word[i], word[i] - 'a' + 1);
            }
        }
    }
}
