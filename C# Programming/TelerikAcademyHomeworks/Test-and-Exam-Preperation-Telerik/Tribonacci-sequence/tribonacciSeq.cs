using System;
using System.Numerics;

    class tribonacciSeq
    {
        static void Main()
        {
            BigInteger firstNum = BigInteger.Parse(Console.ReadLine());
            BigInteger secNum = BigInteger.Parse(Console.ReadLine());
            BigInteger thirdNum = BigInteger.Parse(Console.ReadLine());
            int nThNumber = int.Parse(Console.ReadLine());
            BigInteger sum = 0;

            if (nThNumber > 3)
            {
                for (int i = 4; i <= nThNumber; i++)
                {
                    sum = firstNum + secNum + thirdNum;
                    firstNum = secNum;
                    secNum = thirdNum;
                    thirdNum = sum;


                }
                Console.WriteLine("{0}", sum);
            }
            else
            {
                if (nThNumber == 1) Console.WriteLine(firstNum);
                if (nThNumber == 2) Console.WriteLine(secNum);
                if (nThNumber == 3) Console.WriteLine(thirdNum);
            }
        }
    }

