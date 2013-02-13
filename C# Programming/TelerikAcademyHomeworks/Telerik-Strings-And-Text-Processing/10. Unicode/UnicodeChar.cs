/* Write a program that converts a string
 * to a sequence of C# Unicode character literals. 
 * Use format strings. Sample input:
 */

namespace _10.Unicode
{
    using System;
    using System.Linq;

    class UnicodeChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string textToProcess = Console.ReadLine();
            foreach (char character in textToProcess )
            {
                Console.WriteLine("{1} -> \\u{0:X4}", (int)character, character);
            }
        }
    }
}
