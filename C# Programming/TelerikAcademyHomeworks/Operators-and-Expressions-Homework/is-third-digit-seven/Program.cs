using System;

class isDigitSeven
{
    static void Main()
    {
        int flag=0;
        string myNumber="";
        while (flag == 0)
        {
            Console.WriteLine("Enter a 4 digit Number:");
            myNumber=Console.ReadLine();
            if (myNumber.Length != 4)
            {
                flag = 0;
                Console.WriteLine("Incorrect number of digits! Please try again with a 4 digit number !");
            }
            else
            {
                flag = 1;
            }
        }
        int isThird = int.Parse(myNumber);
        if (((isThird % 1000) - (isThird % 100)) / 100 == 7)
        {
            Console.WriteLine("The Third Digit of the number {0} is 7!", isThird);
        }
        else
        {
            Console.WriteLine("The Third Digit of the number {0} IS NOT 7 !",isThird);
        }

       




    }
}

