/* Write a program that compares two char
 * arrays lexicographically (letter by letter).
*/
namespace Compare_Arrays_Lexigocraphically
{
    using System;
    using System.Linq;

    public class CompareCharArrays
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first array of chars:");
            string input = Console.ReadLine();
            char[] firstArr = input.ToCharArray();
            int firstLenght = firstArr.Length;
            Console.WriteLine("Enter the second array of chars:");
            input = Console.ReadLine();
            char[] secArr = input.ToCharArray();
            int secLenght = secArr.Length;
            int minLenght = Math.Min(firstLenght, secLenght);
            bool isEqual = true;
            for (int i = 0; i < minLenght; i++)
            {
                if (firstArr[i] == secArr[i])
                {
                    continue;
                }
                else
                {
                    isEqual = false;
                    if (firstArr[i] < secArr[i])
                    {
                        Console.WriteLine("The First Array is Lexicographically before the Second Array!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The Second Array is Lexicographically before the First Array!");
                        break;
                    }
                }
            }

            if (isEqual == true && firstLenght < secLenght)
            {
                Console.WriteLine("The first array is lexicografically before the second!");
            }
            else if (isEqual == true && firstLenght > secLenght)
            {
                Console.WriteLine("The second array is lexicografically before the first!");
            }
            else if (isEqual == true && firstLenght == secLenght)
            {
                Console.WriteLine("The arrays are equal!");
            }
        }
    }
}
