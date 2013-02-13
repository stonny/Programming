/* Write a program to check if in
 * a given expression the brackets are put correctly.
 * Example of correct expression: ((a+b)/5-d).
 * Example of incorrect expression: )(a+b)).
 */

namespace _03.IncorrectExpressionInBrackets
{
    using System;
    using System.Linq;

    class BracketsExpression
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Expression:");
            string inputExp = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < inputExp.Length; i++)
            {
                if (inputExp[i] == '(')
                {
                    count ++;
                }
                else if (inputExp[i] == ')')
                {
                    count --;
                }
            }
            if (count != 0)
            {
                Console.WriteLine("Incorrect Expresion!");
            }
            else
            {
                Console.WriteLine("The Expression is correct!");
            }
        }
    }
}
