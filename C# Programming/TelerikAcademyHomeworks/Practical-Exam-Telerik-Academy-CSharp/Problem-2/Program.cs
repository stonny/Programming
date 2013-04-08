using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class TribonacciTriangle
    {
        static void Main(string[] args)
        {
            //input
            BigInteger firstNum = BigInteger.Parse(Console.ReadLine());
            BigInteger secNum = BigInteger.Parse(Console.ReadLine());
            BigInteger thirdNum = BigInteger.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            BigInteger nextNumber = 0;
            int numberOfElements;

            //calculation next number
            Console.WriteLine(firstNum);
            Console.WriteLine(secNum + " " + thirdNum);
            for (int j = 3; j <=lines; j++)
            {
              
                    for (int i = 1; i <= j; i++)
                    {
                        nextNumber = firstNum + secNum + thirdNum;
                        firstNum = secNum;
                        secNum = thirdNum;
                        thirdNum = nextNumber;
                        Console.Write(nextNumber + " ");


                    }
                
               
                Console.WriteLine();
            }



            //output

        }

    }
}
