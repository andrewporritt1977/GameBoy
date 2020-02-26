using System;
using GameBoy20.BlackJackGame;
using GameBoy20.Utils;

namespace GameBoy20.NumberPoke
{
    public class NumberPoke : IGame
    {
        public void LaunchGame()
        {
            NumberPokeGame numberPokeGame = new NumberPokeGame(new CardDeck());
            numberPokeGame.DrawCards();
            Console.WriteLine("Your cards are: " + numberPokeGame.CardOne + " " + numberPokeGame.CardTwo + " " + 
                              numberPokeGame.CardThree);
            Console.WriteLine("Which cards do you wish to hold? Please enter 1, 2, and 3 with comma separation.");
            var heldCards = Console.ReadLine();
            numberPokeGame.HoldCards(heldCards);
            numberPokeGame.DrawCards();
            Console.WriteLine("Your cards are: " + numberPokeGame.CardOne + " " + numberPokeGame.CardTwo + " " + 
                              numberPokeGame.CardThree);
            Console.WriteLine(numberPokeGame.WinStatus());
        }
    }
}