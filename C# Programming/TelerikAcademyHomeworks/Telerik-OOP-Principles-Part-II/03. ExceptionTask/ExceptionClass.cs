using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ExceptionTask
{
    class ExceptionClass<T> : ApplicationException
    {
        public T fromT { get; set; }
        public T toT { get; set; }

        public ExceptionClass(string msg, T min, T max)
            : base(msg)
        {
            this.fromT = min;
            this.toT = max;
        }
    }
}
