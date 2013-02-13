/* Sorting an array means to arrange its elements in
 * increasing order. Write a program to sort an array.
 * Use the "selection sort" algorithm: Find the smallest element,
 * move it at the first position, find the smallest from the rest,
 * move it at the second position, etc.
*/
namespace ArraySort
{
    using System;
    using System.Linq;

   public class SortArray
    {
       public static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Size of the array:");
            int[] myArray = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("arr[{0}]=", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }

            int temp;
            for (int i = 0; i < arraySize - 1; i++)
            {
                for (int j = i + 1; j < arraySize; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                }
            }

            Console.WriteLine(new string('-', 20));
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine("arr[{0}]=" + myArray[i], i);
            }
        }
    }
}
