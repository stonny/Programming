// Write a program to convert hexadecimal numbers to their decimal representation.

namespace _04.HexToDec
{
    using System;
    using System.Linq;

    public class HexToDec
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Hexadecimal Number");
            string myNumber = Console.ReadLine();
            Console.WriteLine("Result In Decimal:");
            Console.WriteLine(ConvertToType(myNumber, 16)); 
        }
        
        public static int ConvertToType(string myNumber, int type)
        {
            int size = myNumber.Length;
            int power = size - 1;
            int result = 0;
            int caseLetter = 0;
            for (int i = 0; i < size; i++)
            {
                switch (myNumber[i])
                {
                    case 'A': caseLetter = 10;
                        break;
                    case 'B': caseLetter = 11;
                        break;
                    case 'C': caseLetter = 12;
                        break;
                    case 'D': caseLetter = 13;
                        break;
                    case 'E': caseLetter = 14;
                        break;
                    case 'F': caseLetter = 15;
                        break;
                    default: caseLetter = int.Parse(Convert.ToString(myNumber[i]));
                        break;
                }

                result = result + caseLetter * (int)(Math.Pow(type, power));
                power--;
            }
            return result;
        }
    }
}
