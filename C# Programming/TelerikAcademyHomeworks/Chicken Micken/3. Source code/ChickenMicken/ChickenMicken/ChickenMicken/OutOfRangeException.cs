using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChickenMicken
{
    public class OutOfRangeException : ApplicationException
    {
        public OutOfRangeException(string message): base(message)
        {
        }
    }
}
