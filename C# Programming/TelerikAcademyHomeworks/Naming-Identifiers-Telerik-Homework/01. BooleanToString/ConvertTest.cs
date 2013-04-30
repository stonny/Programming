using System;
using System.Linq;

namespace _01.BooleanToString
{
    public class ConvertTest
    {
        // Const not being used but I kept it as it shows the naming conventions of the Lecture
        private const int MaxCount = 6;

        public static void Main(string[] args)
        {
            Convert testVariable = new Convert();
            testVariable.BooleanToString(true);
        }
    }
}
