/* Write a method that adds two positive integer 
 * numbers represented as arrays of digits
 * (each array element arr[i] contains a digit;
 * the last digit is kept in arr[0]). 
 * Each of the numbers that will be added could have up to 10 000 digits.
*/
namespace _08._10000Digits
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    public static class SumOfDigits
    {
        public static string ToStringNonLinqy<T>(this T[] array, string delimiter)
        {
            if (array != null)
            {
                if (array.Length > 0)
                {
                    StringBuilder builder = new StringBuilder();

                    builder.Append(array[0]);
                    for (int i = 1; i < array.Length; i++)
                    {
                        builder.Append(delimiter);
                        builder.Append(array[i]);
                    }

                    return builder.ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
            else
            {
                return null;
            }
        }

        public static BigInteger Sum(BigInteger n1, BigInteger n2)
        {
            return n1 + n2;
        }

        public static void Main()
        {
            byte[] arr1 = { 4, 5, 2, 3, 8 };
            Array.Reverse(arr1);
            byte[] arr2 = { 29, 23, 56, 123, 34, 50, 34 };
            Array.Reverse(arr2);

            BigInteger arr1Digits = BigInteger.Parse(ToStringNonLinqy(arr1, string.Empty));
            BigInteger arr2Digits = BigInteger.Parse(ToStringNonLinqy(arr2, string.Empty));

            Console.WriteLine(Sum(arr1Digits, arr2Digits));
        }
    }
}
