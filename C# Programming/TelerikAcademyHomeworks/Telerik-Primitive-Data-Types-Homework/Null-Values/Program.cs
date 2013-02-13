/*Create a program that assigns null values to an
 * integer and to double variables.
 * Try to print them on the console, try to add some values or the null 
 * literal to them and see the result.*/

using System;


class nullVariables
{
    static void Main()
    {
        int? someVar = null;
        double? someVar2 = null;
        Console.WriteLine(someVar);
        Console.WriteLine(someVar2);
        Console.WriteLine(someVar+5);
        Console.WriteLine(someVar2+2.5);

    }
}

