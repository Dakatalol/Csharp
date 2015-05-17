using System;

class CardDeck
{
    static void Main()
    {
        string cardNumber, cardColor;
        for (int i = 1; i <= 4; i++)//loop for the color
        {
            for (int j = 1; j <= 13; j++)//loop for the number
            {
                switch (j)//checking each case of number
                {
                    case 1: cardNumber = "Ace"; break;
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10: cardNumber = j.ToString(); break;
                    case 11: cardNumber = "Jack"; break;
                    case 12: cardNumber = "Queen"; break;
                    case 13: cardNumber = "King"; break;
                    default: cardNumber = ""; break;
                }
                switch (i)//checking each case of color
                {
                    case 1: cardColor = "Clubs"; break;
                    case 2: cardColor = "Diamonds"; break;
                    case 3: cardColor = "Hearts"; break;
                    case 4: cardColor = "Spades"; break;
                    default: cardColor = ""; break;
                }
                Console.WriteLine("{0,5} of {1}", cardNumber, cardColor);
            }
        }
    }
}