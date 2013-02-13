/* Write a program that finds the maximal increasing
 * sequence in an array. Example: 
 * {3, *2, *3, *4, 2, 2, 4}  {2, 3, 4}.
 * */

namespace MaximumIncreasingSequence
{
    using System;
    using System.Linq;

   public class MaxIncreasingSequence
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array elements:");
            int arraySize = int.Parse(Console.ReadLine());
            int[] myArray = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("arr[{0}]=", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }

            int seqLenght = 1;
            int maxSeqLenght = 0;
            int index = 0;
            for (int i = 0; i < arraySize - 1; i++)
            {
                if (myArray[i] < myArray[i + 1])
                {
                    seqLenght++;
                }
                else
                {
                    if (maxSeqLenght < seqLenght)
                    {
                        maxSeqLenght = seqLenght;
                        index = i;
                    }

                    seqLenght = 1;
                }
            }

            if (maxSeqLenght < seqLenght)
            {
                maxSeqLenght = seqLenght;
                index = arraySize - 1;
            }

            Console.Write("{");
            for (int i = index - maxSeqLenght + 1; i < index + 1; i++)
            {
                if (i < index)
                {
                    Console.Write("{0}, ", myArray[i]);
                }
                else
                {
                    Console.Write("{0}", myArray[i]);
                    Console.Write("}");
                }
            }

            Console.WriteLine();
        }
    }
}
