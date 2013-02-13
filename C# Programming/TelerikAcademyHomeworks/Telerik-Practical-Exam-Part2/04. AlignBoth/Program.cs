using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AlignBoth
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            string text = "Beer  beer beer Im\r\n" +
                        "going  for  a beer\r\n" +
                        "Beer  beer beer Im\r\n" +
                        "gonna  drink  some\r\n" +
                        "beer     I    love\r\n" +
                        "drinkiiiiiiiiing\r\n" +
                        "beer lovely lovely\r\n" +
                        "beer                \r\n";
            Console.WriteLine(text);
        }
    }
}