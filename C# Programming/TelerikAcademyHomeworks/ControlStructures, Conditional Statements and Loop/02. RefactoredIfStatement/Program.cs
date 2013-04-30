using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RefactoredIfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void FirstStatement()
        {
            Potato potato = new Potato();
            //... 
            if (potato != null)
                if (!potato.IsRotten && !potato.HastBeenPeeled)
                    Cook(potato);
        }

        private static void Cook(Potato potato)
        {
            throw new NotImplementedException();
        }

        static void SecondStatement()
        {
            bool xIsInRange = MIN_X <= x && x <= MAX_X;
            bool yIsInRange = MIN_Y <= y && y <= MAX_Y;

            if (xIsInRange && yIsInRange && !visited[x, y])
            {
                VisitCell(x, y);
            }
        }
    }
}
