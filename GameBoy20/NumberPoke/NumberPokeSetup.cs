using System;
using GameBoy20.Utils;

namespace GameBoy20.NumberPokeGame
{
    public class NumberPoke : IGame
    {
        public void LaunchGame()
        {
            Setup setup = new Setup();
            setup.DrawCards();
            Console.WriteLine("Your cards are: " + setup.CardOne + " " + setup.CardTwo + " " + 
                              setup.CardThree);
            Console.WriteLine("Which cards do you wish to hold? Please enter 1, 2, and 3 with comma separation.");
            var heldCards = Console.ReadLine();
            setup.HoldCards(heldCards);
            setup.DrawCards();
            Console.WriteLine("Your cards are: " + setup.CardOne + " " + setup.CardTwo + " " + 
                              setup.CardThree);
            Console.WriteLine(setup.WinStatus());
        }
    }
}