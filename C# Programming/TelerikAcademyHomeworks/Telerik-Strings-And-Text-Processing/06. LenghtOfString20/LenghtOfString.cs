/* Write a program that reads from the console a string
 * of maximum 20 characters. 
 * If the length of the string is less than 20, 
 * the rest of the characters should be filled with '*'. 
 * Print the result string into the console.
*/

namespace _06.LenghtOfString20
{
    using System;
    using System.Linq;
    using System.Text;

    class LenghtOfString
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Enter a text to process:");
            sb.Append(Console.ReadLine());
            if (sb.Length < 20)
            {
                sb.Append('*', 20 - sb.Length);
                Console.WriteLine(sb);
            }
            else
            {
                Console.WriteLine("Your input was more than 20 characters !");
                throw new FormatException();
            }
        }
    }
}
