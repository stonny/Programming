/*Write a program that safely compares floating-point numbers with precision of 
0.000001. Examples:
(5.3 ; 6.01)  false;  
(5.00000001 ; 5.00000003)  true*/

using System;


class compareNumbers
{
    static void Main()
    {

        Console.WriteLine("Enter 1st Number: ");
         float numberOne = float.Parse(Console.ReadLine());
         Console.WriteLine("Enter 2nd Number: ");
         float numberTwo = float.Parse(Console.ReadLine());
         bool nEqual = numberOne.Equals(numberTwo);
         Console.WriteLine("Is {0} equal to {1}? -> {2} ",numberOne,numberTwo,nEqual);
         
    }
}
