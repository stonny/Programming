/* You are given an array of strings. 
 * Write a method that sorts the array
 * by the length of its elements 
 * (the number of characters composing them).
*/
namespace _05.StringSort
{
    using System;
    using System.Linq;

    public class StringSortArray
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());
            string[] myArray = new string[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("arr[{0}]=", i);
                myArray[i] = Console.ReadLine();
            }

            string temp = string.Empty;
            for (int i = 0; i < size ; i++)
            {
                for (int j = i + 1; j < size - 1; j++)
                {
                    if(myArray[i].Length< myArray[j].Length)
                    {
                        temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                  
                }
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
