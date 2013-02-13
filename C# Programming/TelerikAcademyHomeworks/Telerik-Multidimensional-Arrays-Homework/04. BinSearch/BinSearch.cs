/* Write a program, that reads from the console 
 * an array of N integers and an integer K, sorts
 * the array and using the method Array.BinSearch() 
 * finds the largest number in the array which is ≤ K. 
 */
namespace _04.BinSearch
{
    using System;
    using System.Linq;

    public class BinSearch
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the size of the array:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K=");
            int k = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}]=", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(myArray);
            int elemIndex = Array.BinarySearch(myArray, k);
            while (elemIndex < 0)
            {
                if (k < myArray[0])
                {
                    break;
                }

                k--;
                elemIndex = Array.BinarySearch(myArray, k);
            }

            if (elemIndex < 0)
            {
                Console.WriteLine("Element not found!");
            }
            else
            {
                Console.WriteLine("K is at index [{0}] = {1}", elemIndex, myArray[elemIndex]);
            }
        }
    }
}
