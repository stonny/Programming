﻿//-----------------------------------------------------------------------
// <copyright file="StringExtensions.cs" company="TelerikAcademy">
//     All rights reserved © Telerik Academy 2012-2013
// </copyright>
//-----------------------------------------------------------------------
namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// This class contains String Extension Methods
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// This method encrypts input with MD5 hash code.
        /// </summary>
        /// <param name="input">Input to encrypt.</param>
        /// <returns>The encrypted input as string.</returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes
            // and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return builder.ToString();
        }

        /// <summary>
        /// This method converts the input into Boolean variable.
        /// </summary>
        /// <param name="input">Input to convert.</param>
        /// <returns>Return true if input is equal to any of the variables in <see cref="stringTrueValue"/>
        /// Returns false if equal elements are not found in <see cref="stringTrueValue"/></returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }
        
        /// <summary>
        /// This method parses input string as 16-bit Signed Integer.
        /// </summary>
        /// <param name="input">Input string to parse.</param>
        /// <returns>Returns the parsed input as 16-bit Signed Integer.</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// This method parses input string as 32-bit Signed Integer.
        /// </summary>
        /// <param name="input">Input string to parse.</param>
        /// <returns>Returns the parsed input as 32-bit Signed Integer.</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// This method parses input string as 64-bit Signed Integer.
        /// </summary>
        /// <param name="input">Input string to parse.</param>
        /// <returns>Returns the parsed input as 64-bit Signed Integer.</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// This method parses the input string into <see cref="System.DateTime"/> format.
        /// </summary>
        /// <param name="input">Input string to parse.</param>
        /// <returns>Returns the parsed string as <see cref="System.DateTime"/>.</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// This method Capitalize the first letter of the input string.
        /// </summary>
        /// <param name="input">Input string to capitalize it's first letter.</param>
        /// <returns>Returns the input with first capital letter.</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// From the inputted string we return the substring situated between
        /// the startString and endString
        /// </summary>
        /// <param name="input">Input string that is going to be used</param>
        /// <param name="startString">The left delimiter</param>
        /// <param name="endString">The right delimiter</param>
        /// <param name="startFrom">The search starts from here</param>
        /// <returns>Substring from the input string. It is being situated
        /// between startString and endString</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// This method converts Cyrillic letters to Latin letters.
        /// </summary>
        /// <param name="input">Input string to convert.</param>
        /// <returns>Returns the converted input as string.</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// This method converts Latin letters to Cyrillic letters.
        /// </summary>
        /// <param name="input">Input string to convert.</param>
        /// <returns>Returns the converted input as string.</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// This method validates username with <see cref="System.Text.RegularExpression"/>.
        /// </summary>
        /// <param name="input">Input string to be filtered.</param>
        /// <returns>Returns the filtered input as string.</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();

            // Removes all non-alphanumeric characters except
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Converts input text from cyrillic to latin letters.
        /// </summary>
        /// <param name="input">Input string that is going to be filtered</param>
        /// <returns>Filtered text as string.</returns>
        public static string ToValidLatinFileName(this string input)
        {
            // Replaces spaces with "-".
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();

            // Removes all non-alphanumeric characters except "." and "-".
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Returns a substring from the inputted string. It starts from the beginning
        /// of the input text and ends at the lesser of: input text length or
        /// the charCount variable
        /// </summary>
        /// <param name="input">Input string for the manipulation</param>
        /// <param name="charsCount">This number points the end of 
        /// the returned substring in case it's less than the input string length</param>
        /// <returns>Returns a substring from the inputted string</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Returns file extension derived from fileName as input string
        /// </summary>
        /// <param name="fileName">fileName as string text</param>
        /// <returns>Returns file extension</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// This method uses dictionary to check if the inputted file extension
        /// is contained as a key
        /// in the dictionary we will have the dictionary value returned.
        /// </summary>
        /// <param name="fileExtension">Used to check if is contained
        /// as key in the dictionary.</param>
        /// <returns>Returns value as String.</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Converts a set of characters from the specified character array 
        /// into a sequence of bytes.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>A byte array containing the specified set of characters.</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
