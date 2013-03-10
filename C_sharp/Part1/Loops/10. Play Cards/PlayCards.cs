using System;

class PlayCards
{
    static void Main()
    {
        string[] cards = {"Ace", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
        string[] suit = { "Spades", "Hearts", "Diamonds", "Clubs" };

        for (int i = 0; i < cards.Length; i++)
        {
            for (int j = 0; j < suit.Length; j++)
            {
                Console.Write(cards[i] + " " + suit[j] + " ");
            }
            Console.WriteLine();
        }
    }
}

