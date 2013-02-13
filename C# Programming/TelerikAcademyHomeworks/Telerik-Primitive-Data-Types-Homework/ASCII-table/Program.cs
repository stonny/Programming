/*Prints out ASCII table */
using System;
class Table
{
    static void Main()
    {
        int i = 0;
        char c;
       
        for (i = 0; i < 255; i++)
        {
            c=(char)i;
            Console.WriteLine(i+"->"+c);
           
        }
    }
}

