/* Write a program that finds the maximal sequence of equal elements in an array.
*		Example: {2, 1, 1, 2, 3, 3, *2, *2, *2, 1}  {2, 2, 2}.
*/
namespace MaximalSequenceOfEqualElements
{
    using System;
    using System.Linq;

   public class SequenceOfElements
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of array elements:");
            int arraySize = int.Parse(Console.ReadLine());
            int[] myArray = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("arr[{0}]=", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }

            int numEqualElm = 1;
            int equalElm = 0;
            int maxNumEqualElm = numEqualElm;
            for (int i = 0; i < arraySize - 1; i++)
            {
                if (myArray[i] == myArray[i + 1])
                {
                    numEqualElm++;

                    if (maxNumEqualElm < numEqualElm)
                    {
                        maxNumEqualElm = numEqualElm;
                        equalElm = myArray[i];
                    }
                }
                else
                {
                    numEqualElm = 1;
                }
            }

            Console.Write("{");
            for (int i = 0; i < maxNumEqualElm; i++)
            {
                if (i == maxNumEqualElm - 1)
                {
                    Console.Write(equalElm);
                }
                else
                {
                    Console.Write(equalElm + ", ");
                }
            }

            Console.Write("}");
            Console.WriteLine();
        }
    }
}
