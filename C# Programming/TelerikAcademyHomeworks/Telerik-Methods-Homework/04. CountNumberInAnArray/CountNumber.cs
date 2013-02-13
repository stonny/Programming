/* Write a method that counts how many times given
 * number appears in given array. Write a test
 * program to check if the method is working correctly.
 */
namespace _04.CountNumberInAnArray
{
    using System;
    using System.Linq;

    public class CountNumber
    {
        public static void Main(string[] args)
        {
            int[] myArray = new int[] { 1, 2, 3, 5, 3, 6, 10, 3, 2, 5 };
            int number = 3;
            /*
             * Console Input for Testing
            Console.WriteLine("Enter size of the array:");
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                Console.Write("arr[{0}]=", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter desired number:");
            int number = int.Parse(Console.ReadLine());
            */
            Console.WriteLine(NumberCount(myArray, number));
        }

        private static int NumberCount(int[] myArray, int number)
        {
            int count = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == number)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
