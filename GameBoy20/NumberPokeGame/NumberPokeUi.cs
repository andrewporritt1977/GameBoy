using System;
using System.Collections.Generic;
using System.Text;

namespace GameBoy20.NumberPokeGame
{
    class NumberPokeUi : INumberPokeUi
    {
        public void InformWinStatus(string winStatus)
        {
            Console.WriteLine(winStatus);
        }

        public void InformYourCards(string cardOne, string cardTwo, string cardThree)
        {
            Console.WriteLine("Your cards are: " + cardOne + " " + cardTwo + " " + cardThree);
        }

        public string ObtainCardsToHold()
        {
            Console.WriteLine("Which cards do you wish to hold? Please enter 1, 2, and 3 with comma separation.");
            return Console.ReadLine();
        }
    }
}
