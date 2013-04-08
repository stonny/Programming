/* Implement an extension method Substring(int index, int length)
 * for the class StringBuilder that returns new StringBuilder and 
 * has the same functionality as Substring in the class String.
 */
using System;
using System.Text;

public class TestSubstring
{
    static void Main(string[] args)
    {
        // Testin the extension method with different values, even wrong ones
        StringBuilder testString = new StringBuilder();
        testString.AppendLine("I am a text string");
        Console.WriteLine(testString.Substring(5,5).ToString());
        Console.WriteLine(testString.Substring(0, 5).ToString());
        //Console.WriteLine(testString.Substring(18, 1).ToString());
        //Console.WriteLine(testString.Substring(0, 30).ToString());
        //Console.WriteLine(testString.Substring(-5, 10).ToString());
    }
}

