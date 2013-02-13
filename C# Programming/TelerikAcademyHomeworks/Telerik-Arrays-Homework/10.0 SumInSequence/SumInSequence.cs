/* Write a program that finds in given array of integers
 * a sequence of given sum S (if present). 
 * Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}
 */
namespace SumInSequence
{
    using System;
    using System.Linq;

    public class SumInSequence
    {
        public static void Main(string[] args)
        {   
            int sumOfSequence;
            int indexEnd = 0;
            int indexStart = 0;
            int j = 0;
            int i = 0;
            int sum = 0;
            Console.WriteLine("Enter the Size of the array:");
            int arraySize = int.Parse(Console.ReadLine());
            int[] myArray = new int[arraySize];
            for (i = 0; i < arraySize; i++)
            {
                Console.Write("arr[{0}]=", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the Sum:");

            sumOfSequence = int.Parse(Console.ReadLine());
            i = 0;
            while (j != (arraySize - 2))
            {
                if (i == (arraySize - 1))
                {
                    j++;
                    i = j;
                    sum = 0;
                }

                sum += myArray[i];
                if (sum == sumOfSequence)
                {
                    indexEnd = i;
                    indexStart = j;
                }

                i++;
            }

            Console.Write("{");
            for (i = indexStart; i <= indexEnd; i++)
            {
                if (i == indexEnd)
                {
                    Console.Write("{0}", myArray[i]);
                }
                else
                {
                    Console.Write("{0}, ", myArray[i]);
                }
            }

            Console.Write("}");
            Console.WriteLine();
        }
    }
}
