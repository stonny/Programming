/*Write a program that prints an isosceles triangle of 9 copyright symbols ©.
 * Use Windows Character Map to find the Unicode code of the © symbol. 
 * Note: the © symbol may be displayed incorrectly.*/

using System;
using System.Text;
class copyrightTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        char copy = '\u00A9';

        Console.WriteLine("   {0}\n  {0} {0}\n {0}   {0}\n{0} {0} {0} {0}", copy);

    }
}
        
            
            
            

            

