// Write a program to convert binary numbers to hexadecimal numbers (directly).
namespace _06.BinaryToHex_Directly_
{
    using System;
    using System.Linq;
    
    public class BinToHexDirectly
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a binary number");
            string myNumber = Console.ReadLine();
            BinToHex(myNumber);
            Console.WriteLine("Number in Hex:");
            Console.WriteLine(BinToHex(myNumber));
        }

        public static string BinToHex(string myNumber)
        {
            int remainder = myNumber.Length % 4;
            if (remainder != 0)
            {
                myNumber = new string('0', 4 - remainder) + myNumber; // filling the string with '0', 4 - remainder times
            }                                                         // so we can divide the binary into numbers of 4 digits
            string result = string.Empty;
            for (int i = 0; i < myNumber.Length; i += 4)
            {
                string currentElement = myNumber.Substring(i, 4); // now that we have even number of digits
                switch (currentElement)                           // we take each 4 digits and do the calculations with them
                {
                    case "1010": result = result + "A";
                        break;
                    case "1011": result = result + "B";           // we check for letters 
                        break;
                    case "1100": result = result + "C";
                        break;
                    case "1101": result = result + "D";
                        break;
                    case "1110": result = result + "E";
                        break;
                    case "1111": result = result + "F";
                        break;
                    default:
                        {
                            int power = currentElement.Length - 1;          // else we convert to decimal
                            int current = 0;
                            for (int j = 0; j < 4; j++)
                            {
                                current+= int.Parse(currentElement[j].ToString()) * (int)(Math.Pow(2, power));
                                power--;
                            }

                            result = result + current;
                        }
                        break;
                }
            }
            return result;
        }
    }
}
