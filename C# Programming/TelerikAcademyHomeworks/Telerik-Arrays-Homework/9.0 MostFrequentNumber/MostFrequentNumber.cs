/* Write a program that finds the most frequent number in an array. Example:
*	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
*/
namespace MostFrequentNumber
{
    using System;
    using System.Linq;

   public class MostFrequentNumber
    {
      public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size of the array:");
            int arraySize = int.Parse(Console.ReadLine());
            int[] myArray = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("arr[{0}]=", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }

            int times = 0;
            int numbers = 0;
            int maxNumbers = 0;
            int maxTimes = 0;
            for (int i = 0; i < arraySize; i++)
            {
                numbers = 0;
                times = 0;
                for (int j = 0; j < arraySize; j++)
                {
                    if (myArray[i] == myArray[j])
                    {
                        times++;
                        numbers = myArray[i];
                    }

                    if (maxTimes < times)
                    {
                        maxTimes = times;
                        maxNumbers = numbers;
                    }
                }
            }

            Console.WriteLine("Most Frequent number is: {0} ({1} Times)", maxNumbers, maxTimes);
        }
    }
}
