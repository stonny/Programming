/* Write a program that allocates array of 20 integers 
 * and initializes each element by its index multiplied by 5. 
 * Print the obtained array on the console.
*/
namespace MultipliedArray
{
    using System;
    using System.Linq;

    public class MultiplyTheArray
    {
       public static void Main(string[] args)
        {
            int[] myArray = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.Write("arr[{0}]=", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The Multiplied array is:");
            for (int i = 0; i < 20; i++)
            {
                myArray[i] *= 5;
                Console.WriteLine("arr[{0}]=" + myArray[i], i);    
            }
        }
    }
}
