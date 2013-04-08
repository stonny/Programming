// Using delegates write a class Timer that has can execute certain method at each t seconds.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


class ExecuteMethodTimer
{


    public static void Main()
    {
        Timer obj = new Timer();
        Ticker timer = new Ticker(obj.TickerValue);

        while (true)
        {
            Thread.Sleep(1000);
            Console.Clear();
            timer(0);
        }
    }
}

