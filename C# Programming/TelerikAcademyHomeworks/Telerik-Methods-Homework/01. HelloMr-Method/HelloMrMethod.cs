/* Write a method that asks the user for his name 
 * and prints “Hello, <name>” (for example, “Hello, Peter!”).
 * Write a program to test this method.
*/
namespace _01.HelloMr_Method
{
    using System;
    using System.Linq;

    public class HelloMrMethod
    {
        public static void Main(string[] args)
        {
            HelloMr();
        }

        private static void HelloMr()
        {
            Console.Write("Please Enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello, {0} !", userName);
        }
    }
}
