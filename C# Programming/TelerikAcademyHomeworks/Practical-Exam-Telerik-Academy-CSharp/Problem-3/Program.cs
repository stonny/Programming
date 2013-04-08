using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Sheets
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = n;
            int A1 = 0;
            int other = 0;
            for (int i = n; i >=0; i++)
            {
                if (sum % 2 == 1)
                    A1++;
                else
                    other++;
            }

            
        }
    }
}
