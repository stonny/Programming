using System;

public delegate void Ticker(int start);

public class Timer
{
    public int Nums { get; set; }

    public void TickerValue(int start)
    {
        Console.WriteLine("Time passed: {0} s", this.Nums);
        this.Nums++;
    }
}