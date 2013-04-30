using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RefactorLoopStatement
{
    class LoopStatement
    {
        static void Main(string[] args)
        {
            bool expectedValueFound = false;
            int[] array = new int[];
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(array[i]);

                if (i % 10 == 0)
                {
                    if (array[i] == expectedValueFound)
                    {
                        expectedValueFound = true;
                        break;
                    }
                }

            }

            if (expectedValueFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
