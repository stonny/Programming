using System;


class exchange
{
    static void Main()
    {
        byte firstValue = 5, secondValue = 10, exchValue;
        exchValue = firstValue;
        firstValue =secondValue;
        secondValue = exchValue;
        Console.WriteLine("{0},{1}",firstValue,secondValue);


    }
}

