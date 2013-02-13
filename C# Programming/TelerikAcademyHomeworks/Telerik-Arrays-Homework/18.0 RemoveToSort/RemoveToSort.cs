/* Write a program that reads an array of integers and removes 
 * from it a minimal number of elements in such way that the
 * remaining array is sorted in increasing order.
 * Print the remaining sorted array. 
 * Example: {6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}
 */
namespace _18._0_RemoveToSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveToSort
    {
       public static void Main()
        {
            int[] myArray = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
            int length = ((2 << myArray.Length) - 1) - 1;
            List<int> sort = new List<int>();
            List<int> checker = new List<int>();
            int minValue;
            int counter = 0;
            int count = 0;

            for (int i = 0; i <= length; i++)
            {
                counter = 0;
                minValue = int.MinValue;
                for (int k = 0; k < myArray.Length; k++)
                {
                    if ((((i >> k) & 1) == 1) && (minValue <= myArray[k]))
                    {
                        minValue = myArray[k];
                        checker.Add(myArray[k]);
                        counter++;
                    }
                }

                if (counter > count)
                {
                    sort.Clear();
                    count = counter;
                    for (int k = 0; k < checker.Count; k++)
                    {
                        sort.Add(checker[k]);
                    }
                }

                checker.Clear();
            }

            Console.Write("{");
            for (int index = 0; index < sort.Count; index++)
            {
                if (index == sort.Count - 1)
                {
                    Console.Write(sort[index]);
                }
                else
                {
                    Console.Write(sort[index] + ", ");
                }
            }

            Console.Write("}");
            Console.WriteLine();
        }
    }
}
