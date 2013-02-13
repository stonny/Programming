// Write a program to convert binary numbers to their decimal representation.

namespace _02.BinaryToDecimal
{
    using System;
    using System.Linq;

    public class BinaryToDecimal
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Binary Number");
            long myNumber = long.Parse(Console.ReadLine());
            Console.WriteLine(ConvertToType(myNumber, 2)); 
        }
        
        public static int ConvertToType(long myNumber, int type)
        {
            string stringNumber = myNumber.ToString();
            int size = stringNumber.Length;
            int power = size - 1;
            int result = 0;
            for (int i = 0; i < size; i++)
            {
                result = result + int.Parse(stringNumber[i].ToString()) * (int)(Math.Pow(type, power));
                power--;
            }

            return result;
        }
    }
}
