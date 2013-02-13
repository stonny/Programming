/* Write a program that encodes and decodes 
 * a string using given encryption key (cipher). 
 * The key consists of a sequence of characters. 
 * The encoding/decoding is done by performing XOR 
 * (exclusive or) operation over the first letter of 
 * the string with the first of the key, the second – 
 * with the second, etc. When the last key character is reached, 
 * the next is the first.
 */
namespace _07.DecryptString
{
    using System;
    using System.Linq;
    using System.Text;

    public class DecryptString
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();
            Console.WriteLine("Enter a cipfer:");
            string cipfer = Console.ReadLine();

            string encryptedString = Encrypt(str, cipfer);

            Decrypt(encryptedString, cipfer);
        }
  
        private static string Encrypt(string str, string cipfer)
        {
            StringBuilder encryption = new StringBuilder();
            for (int i = 0, cipfCounter = 0; i < str.Length; i++, cipfCounter++)
            {
                encryption.Append((char)((int)str[i] ^ (int)cipfer[cipfCounter]));
                if (cipfCounter + 1 == cipfer.Length)
                {
                    cipfCounter = 0;
                }
            }
            string encryptedString = encryption.ToString();
            Console.WriteLine("The encrypted string is:");
            Console.WriteLine(encryptedString);
            return encryptedString;
        }
  
        private static void Decrypt(string encryptedString, string cipfer)
        {
            StringBuilder decryption = new StringBuilder();
            for (int i = 0, cipfCounter = 0; i < encryptedString.Length; i++, cipfCounter++)
            {
                decryption.Append((char)((int)encryptedString[i] ^ (int)cipfer[cipfCounter]));
                if (cipfCounter + 1 == cipfer.Length)
                {
                    cipfCounter = 0;
                }
            }
            Console.WriteLine("The decrypted string is:");
            Console.WriteLine(decryption.ToString());
        }
    }
}
