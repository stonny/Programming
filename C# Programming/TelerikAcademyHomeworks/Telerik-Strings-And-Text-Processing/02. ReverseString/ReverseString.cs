/* Write a program that reads a string, 
 * reverses it and prints the result at the console.
 * Example: "sample" -> "elpmas".
*/
namespace _02.ReverseString
{
    using System;
    using System.Linq;
    using System.Text;

    class ReverseString
    {
        static void Main(string[] args)
        {
            StringBuilder reversedWord = new StringBuilder();
          
            Console.WriteLine("Enter a word:");
            string wordToReverse = Console.ReadLine();

            for (int i = wordToReverse.Length - 1; i >= 0; i--)
            {
                reversedWord.Append(wordToReverse[i]);
            }
            Console.WriteLine(reversedWord);
        }
    }
}
