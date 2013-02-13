/*Write a method that checks if the element
 * at given position in given array of integers 
 * is bigger than its two neighbors (when such exist).
*/
namespace _05.IsBiggerThanOtherNeighbours
{
    using System;
    using System.Linq;

    public class BiggerThanNeighbours
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

            Console.WriteLine("Enter the position of the number:");
            int position = int.Parse(Console.ReadLine());
            
            IsBigger(myArray, position);
        }

        private static void IsBigger(int[] myArray, int position)
        {
            try
            {
                if ((myArray[position] > myArray[position + 1]) &&
                    (myArray[position] > myArray[position - 1]))
                {
                    Console.WriteLine("The Element[{0}] at position {1} is bigger \r\n than his neighbours [{2}] at position {3} and {4} at position {5}",
                        myArray[position], position, myArray[position - 1], position - 1, myArray[position + 1], position + 1);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("There are no neighbours !");
                throw;
            }
        }
    }
}
