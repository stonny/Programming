/* Write a program that finds the sequence of maximal sum in given array. Example:
*	{2, 3, -6, -1, *2, *-1, *6, *4, -8, 8}  {2, -1, 6, 4}
*/
namespace SequenceOfMaximalSum
{
    using System;
    using System.Linq;

    public class SeqOfMaxSum
    {
        public static void Main(string[] args)
        {
            int maxSum = 0;
            int indexEnd = 0;
            int indexStart = 0;
            int i = 0;
            int j = 0;
            int sum = 0;
            Console.WriteLine("Enter the Size of the array:");
            int arraySize = int.Parse(Console.ReadLine());
            int[] myArray = new int[arraySize];
            for (i = 0; i < arraySize; i++)
            {
                Console.Write("arr[{0}]=", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }

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
                if (maxSum < sum)
                {
                    indexEnd = i;
                    maxSum = sum;
                    indexStart = j;
                }

                i++;
            }

            Console.Write("{");
            for (i = indexStart; i < indexEnd; i++)
            {
                if (i == indexEnd - 1)
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
