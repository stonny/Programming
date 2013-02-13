// Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

namespace _07.ConvertToAny
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ConvertFromToAny
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the type of the system to convert from:");
            int s = int.Parse(Console.ReadLine());
            Console.Write("Enter number from system type {0} :", s);
            string myNumber = Console.ReadLine();
            Console.Write("Enter the system you want to convert to:");
            int d = int.Parse(Console.ReadLine());
            string numberInDec = (ConvertToDec(myNumber,s));
            ConvertFromDec(int.Parse(numberInDec), d);
        }

        public static string ConvertToDec(string myNumber, int type)
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
            return result.ToString();
        }

        static void ConvertFromDec(int myNumber, int type)
        {
            List<int> result = new List<int>();
            if (type > 10)
            {
                while (myNumber > 0)
                {
                    result.Add(myNumber % type);
                    myNumber = myNumber / type;
                }
                result.Reverse();
                foreach (var item in result)
                {
                    switch (item)
                    {
                        case 10: Console.Write("A");
                            break;
                        case 11: Console.Write("B");
                            break;
                        case 12: Console.Write("C");
                            break;
                        case 13: Console.Write("D");
                            break;
                        case 14: Console.Write("E");
                            break;
                        case 15: Console.Write("F");
                            break;
                        default: Console.Write(item);
                            break;
                    }
                }
                Console.WriteLine();
            }
            else
            {
                while (myNumber > 0)
                {
                    result.Add(myNumber % type);
                    myNumber = myNumber / type;
                }
                result.Reverse();
                foreach (var item in result)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
        }
    }
}
