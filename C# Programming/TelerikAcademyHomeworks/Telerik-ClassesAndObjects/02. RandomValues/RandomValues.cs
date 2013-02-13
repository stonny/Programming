// Write a program that generates and prints to the console 10 random values in the range [100, 200].

namespace _02.RandomValues
{
    using System;
    using System.Linq;

    class RandomValues
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine(rand.Next(100,201));
            }
        }
    }
}
