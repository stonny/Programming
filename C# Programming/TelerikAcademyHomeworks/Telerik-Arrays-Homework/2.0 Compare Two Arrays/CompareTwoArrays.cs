/* Write a program that reads two arrays from 
 * the console and compares them element by element.
*/
namespace CompareArrays
{
    using System;
    using System.Linq;

    public class CompareTwoArrays
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter how much elements you want to compare:");
            int arrayElements = int.Parse(Console.ReadLine());
            int[] firstArray = new int[arrayElements];
            int[] secArray = new int[arrayElements];
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Enter the elements of the first array:");
            for (int i = 0; i < arrayElements; i++)
            {
                Console.Write("arr[{0}]=", i);
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Enter the elements of the second array:");
            for (int i = 0; i < arrayElements; i++)
            {
                Console.Write("arr[{0}]=", i);
                secArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(new string('-', 20));
            for (int i = 0; i < arrayElements; i++)
            {
                if (firstArray[i] == secArray[i])
                {
                    Console.WriteLine(firstArray[i] + " = " + secArray[i] + "? -> True");
                }
                else
                {
                    Console.WriteLine(firstArray[i] + " = " + secArray[i] + "? -> False");
                }
            }
        }
    }
}
