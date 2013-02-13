// Write a program to convert hexadecimal numbers to binary numbers (directly).

namespace _05.HexToBin
{
    using System;
    using System.Linq;

    public class HexToBin
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Hexadecimal number");
            string myNumber = Console.ReadLine();
            HexToBinary(myNumber);
            Console.WriteLine("Number in Binary:");
            Console.WriteLine(HexToBinary(myNumber));
        }

        public static string HexToBinary(string myNumber)
        {
            string result = string.Empty;
            int tempNumber = 0;      // we take a temporary Number where we will save each Hex number and convert
            for (int i = 0; i < myNumber.Length; i++)     // into 4 digits binary number before 
            {                                             // parsing it to the final result
                if (Char.IsLetter(myNumber[i]))
                {
                    switch (myNumber[i])
                    {
                        case 'A': result = result + "1010";
                            break;
                        case 'B': result = result + "1011";           // we check for letters 
                            break;
                        case 'C': result = result + "1100";
                            break;
                        case 'D': result = result + "1101";
                            break;
                        case 'E': result = result + "1110";
                            break;
                        case 'F': result = result + "1111";
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    tempNumber = int.Parse(myNumber[i].ToString());    // we take the value of the first number
                    string tempResult = string.Empty;
                    int remainder = 0;
                    while (tempNumber > 0)
                    {
                        tempResult =  (tempNumber % 2) + tempResult;  // converting it to decimal
                        tempNumber /= 2;
                    }

                    remainder = tempResult.Length % 4;
                    if (remainder != 0)                 // here we check the digits of the number
                    {                                   // if they are not 4 we add '0', remainder times
                        result = result + new string('0', 4 - remainder) + tempResult;
                    }
                    else                                // if they are 4 we simply add the 4 digit binary to the final string
                    {
                        result = result + tempResult;
                    }
                }
            }

            return result;
        }
    }
}
