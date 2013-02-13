/* Write a method that returns the index of the
 * first element in array that is bigger than its 
 * neighbors, or -1, if there’s no such element.
 * Use the method from the previous exercise. */
namespace _06.IndexOfBiggerNeighbours
{
    using System;
    using System.Linq;

    public class IndexOfBiggestNeighbour
    {
        public static void Main(string[] args)
        {
            // int[] myArray = new int[] { 1, 2, 3, 5, 3, 6, 10, 3, 2, 5 };
            // int position = 3;

            // Console Input for Testing
            Console.WriteLine("Enter size of the array:");
            int size = int.Parse(Console.ReadLine());
            int[] myArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("arr[{0}]=", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }

            IsBigger(myArray);
        }

        private static void IsBigger(int[] myArray)
        {
            bool isNeighbour = false;

                for (int i = 1; i < myArray.Length - 1; i++)
                {
                    if ((myArray[i] > myArray[i + 1]) &&
                        (myArray[i] > myArray[i - 1]))
                    {
                        isNeighbour = true;
                        Console.WriteLine("The Element [{0}] with index {1} is bigger than his neighbours !", myArray[i], i);
                        break;
                    }
                }

                if (isNeighbour == false)
                {
                    Console.WriteLine("-1");
                }
        }
    }
}
