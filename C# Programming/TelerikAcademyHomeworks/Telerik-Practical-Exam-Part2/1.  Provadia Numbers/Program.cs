using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _1.Provadia_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] upCaseLetters = new char[26];
            char[] lowerCaseLetters = new char[26];
            int j = 65;
            for (int i = 0; i < 26; i++)
            {
                upCaseLetters[i] = (char)j;
                j++;
            }
            j = 97;
            for (int i = 0; i < 26; i++)
            {
                lowerCaseLetters[i] = (char)j;
                j++;
            }
            BigInteger inputNumber = BigInteger.Parse(Console.ReadLine());

            string result = string.Empty;
            string[] myArray = new string[256];
            for (int i = 0; i < 256; i++)
            {
                int remainder = i % 26;
                int wholePart = i / 26;
                if (i < 26)
                {
                    myArray[i] += upCaseLetters[remainder];
                }
                else
                {
                    myArray[i] += (lowerCaseLetters[wholePart - 1]).ToString() + (upCaseLetters[remainder]).ToString();
                }
            }
            if (inputNumber == 0)
            {
                Console.WriteLine(myArray[0]);
            }
            else
            {
                while (inputNumber > 0)
                {
                    BigInteger remainder = inputNumber % 256;
                    result = myArray[(int)remainder] + result;
                    inputNumber /= 256;
                }
                Console.WriteLine(result);
            }
        }
    }
}
