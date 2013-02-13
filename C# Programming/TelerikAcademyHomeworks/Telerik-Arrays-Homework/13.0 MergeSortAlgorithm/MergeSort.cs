/* * Write a program that sorts an array of
 * integers using the merge sort algorithm (find it in Wikipedia).
*/
namespace _13._0_MergeSortAlgorithm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

public class MergeSorting
{
        public static void Main()
        {
            Console.WriteLine("Enter the size of the array:");
            int arraySize = int.Parse(Console.ReadLine());
            List<int> array = new List<int>();
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("arr[{0}]=", i);
                array.Add(int.Parse(Console.ReadLine()));
            }

            List<int> sortedArray = MakeSort(array);

            foreach (int item in sortedArray)
            {
                Console.WriteLine(item);
            }
        }

        public static List<int> MakeSort(List<int> array)
        {
            List<int> firstHalf = new List<int>();
            List<int> secondHalf = new List<int>();
            List<int> merge = new List<int>();
            if (array.Count > 1)
            {
                foreach (int element in array)
                {
                    if (firstHalf.Count < array.Count / 2)
                    {
                        firstHalf.Add(element);
                    }
                    else
                    {
                        secondHalf.Add(element);
                    }
                }

                List<int> firstSorted = MakeSort(firstHalf);
                List<int> secondSorted = MakeSort(secondHalf);
                merge = MergeLists(firstSorted, secondSorted);
            }
            else
            {
                merge.Add(array[0]);
            }

            return merge;
        }

        public static List<int> MergeLists(List<int> first, List<int> second)
        {
            List<int> combine = new List<int>();
            while ((first.Count > 0) && (second.Count > 0))
            {
                if (first[0] < second[0])
                {
                    combine.Add(first[0]);
                    first.RemoveAt(0);
                }
                else
                {
                    combine.Add(second[0]);
                    second.RemoveAt(0);
                }
            }

            foreach (int item in first)
            {
                combine.Add(item);
            }

            foreach (int item in second)
            {
                combine.Add(item);
            }

            return combine;
        }
    }
}
