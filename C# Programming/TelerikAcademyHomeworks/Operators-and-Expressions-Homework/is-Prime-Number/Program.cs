using System;

class isPrimeNumber
{
    static void Main()
    {
        int dividers=1;
        Console.WriteLine("Please enter a positive number (n<=100) to check if its PRIME!");
        int isPrime = int.Parse(Console.ReadLine());

        for (int i = 2; i < 100; i++)
        {
            if (isPrime % i == 0)
            {
                dividers += 1;
                if (dividers > 2)
                {
                    Console.WriteLine("The Number {0} Is NOT PRIME", isPrime);
                    break;
                    
                }
            }
        }
            if(dividers==2)
            {
                Console.WriteLine("The Number {0} IS PRIME!",isPrime);
            }
           

       
    }
}

