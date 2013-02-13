using System;

class cardsFromDeck
{
    static void Main()
    {
        string num = "";
        string suit = "";
        for (int i = 1; i <= 13; i++)
        {
            switch (i)
            {
                case 1:
                    num = "Ace";
                    break;
                case 2:
                    num = "Two";
                    break;
                case 3:
                    num = "Three";
                    break;
                case 4:
                    num = "Four";
                    break;
                case 5:
                    num = "Fife";
                    break;
                case 6:
                    num = "Six";
                    break;
                case 7:
                    num = "Seven";
                    break;
                case 8:
                    num = "Eight";
                    break;
                case 9:
                    num = "Nine";
                    break;
                case 10:
                    num = "Ten";
                    break;
                case 11:
                    num = "Jack";
                    break;
                case 12:
                    num = "Queen";
                    break;
                case 13:
                    num = "King";
                    break;
            }
            for (int k = 1; k <= 4; k++)
            {
                switch (k)
                {
                    case 1:
                        suit = "Clubs ";
                        break;
                    case 2:
                        suit = "Diamonds ";
                        break;
                    case 3:
                        suit = "Hearts ";
                        break;
                    case 4:
                        suit = "Spades ";
                        break;
                }
                Console.WriteLine("{0} of {1}", num, suit);
            }
            
        }
    }
}

