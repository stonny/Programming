using System;

class numberToText
{
    static void Main()
    {

        Console.WriteLine("Enter a number you want to conver in text(1-999):");
        int myNumber = int.Parse(Console.ReadLine());
        int unit = (myNumber % 100)%10; //units
        int tens = (myNumber % 100) / 10; //tens
        int hundred = (myNumber / 100); //hundreds
        string[] hundredsAndUnits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" }; 
        string[] specials = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] tenss={ " ", " ", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        if (myNumber > -1 && myNumber < 1000)
        {
            if (myNumber < 10)
            {
                Console.WriteLine("{0}->{1}",myNumber ,hundredsAndUnits[unit]);
            }
            if(myNumber>9 && myNumber <20)
            {
                Console.WriteLine("{0}->{1}",myNumber , specials[unit]);
            }
            if (myNumber > 19 && myNumber < 100)
            {
                if (unit == 0)
                {
                    Console.WriteLine("{0}->{1}",myNumber , tenss[tens]);
                }
                else
                {
                    Console.WriteLine("{0}->{1}{2}",myNumber , tenss[tens],hundredsAndUnits [unit]);
                }
            }
            if (myNumber > 99)
            {
                 if (unit > 0 && tens < 1)
                {
                    Console.WriteLine("{0}->{1} hundred and {2}",myNumber , hundredsAndUnits [hundred], hundredsAndUnits[unit]);
                }
                if (tens > 0 && tens < 2)
                {
                    Console.WriteLine("{0}->{1} hundred and {2}",myNumber , hundredsAndUnits [hundred], tenss[unit]);
                }
                if (tens >= 2)
                {
                    if (unit == 0)
                    {
                        Console.WriteLine("{0}->{1} hundred and {2}",myNumber, hundredsAndUnits [hundred], tenss[tens]);
                    }
                    else
                    {
                        Console.WriteLine("{0}->{1} hundred {2} {3}",myNumber, hundredsAndUnits [hundred], tenss [tens], hundredsAndUnits [unit]);
                    }
                }
                if (unit==0 && tens==0) 
                {
                    Console.WriteLine("{0}->{1} hundred",myNumber, hundredsAndUnits [hundred]);
                }
            }
        }
    }
}
