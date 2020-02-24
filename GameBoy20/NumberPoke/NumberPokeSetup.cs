using System;
using GameBoy20.Utils;

namespace GameBoy20
{
    public class NumberPokeGame : IGame
    {
        public void LaunchGame()
        {
            NumberPoke numberPoke = new NumberPoke();
            numberPoke.DrawCards();
            Console.WriteLine("Your cards are: " + numberPoke.CardOne + " " + numberPoke.CardTwo + " " + 
                              numberPoke.CardThree);
            Console.WriteLine("Which cards do you wish to hold? Please enter 1, 2, and 3 with comma separation.");
            var heldCards = Console.ReadLine();
            numberPoke.HoldCards(heldCards);
        }
    }
}