using System;

namespace GameBoy20.NumberPokeGame
{
    class NumberPokeUi : INumberPokeUi
    {
        public void InformLose()
        {
            Console.WriteLine("You have lost rip");
        }

        public void InformNewLine()
        {
            Console.WriteLine("");
        }

        public void InformCards(Hand hand)
        {
            Console.WriteLine("Your cards are: " + hand.CardOne + " " + hand.CardTwo + " " + hand.CardThree);
        }

        public void InformSuperWin()
        {
            Console.WriteLine("You have super won");
        }

        public void InformWin()
        {
            Console.WriteLine("You've done a boring win thing");
        }

        public void InformWinStatus(string winStatus)
        {
            Console.WriteLine(winStatus);
        }

        public string ObtainCardsToHold()
        {
            Console.WriteLine("Which cards do you wish to hold? Please enter 1, 2, and 3 with comma separation.");
            return Console.ReadLine();
        }
    }
}
