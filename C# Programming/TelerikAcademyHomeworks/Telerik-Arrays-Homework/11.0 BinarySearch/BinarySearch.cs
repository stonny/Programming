/* Write a program that finds the index of given element 
 * in a sorted array of integers by using the binary 
 * search algorithm (find it in Wikipedia).
*/
namespace BinarySearch
{
    using System;
    using System.Linq;

    public class BinarySearch
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

            Console.WriteLine("Search for a number:");
            int searchedNumber = int.Parse(Console.ReadLine());
            int middle = 0;
            int start = 0;
            int end = arraySize - 1;
            bool isValid = false;
            Array.Sort(myArray);

            while (start <= end)
            {
                middle = (start + end) / 2;
                if (myArray[middle] == searchedNumber)
                {
                    Console.WriteLine("Index=\"{0}\"", middle);
                    isValid = true;
                    break;
                }

                if (myArray[middle] < searchedNumber)
                {
                    start = middle + 1;
                }

                if (myArray[middle] > searchedNumber)
                {
                    end = middle - 1;
                }
            }

            if (isValid == false)
            {
                Console.WriteLine("That number wasn't found!");
            }
        }
    }
}
