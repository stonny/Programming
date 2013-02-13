/*Declare two string variables and assign them with following value:
"The "use" of quotations causes difficulties."

	Do the above in two different ways: with and without using quoted strings.

 * */

using System;

class twoStrings
{
    static void Main()
    {
        string one = "\"The \"use\" of quotations causes difficulties.\"";
        string two= "The \"use\" of quotations causes difficulties.";
        Console.WriteLine("This is quoted string: "+one);
        Console.WriteLine("This is string without quotes: "+two);
    }
}

