using System;
using GameBoy20.BlackJackGame;
using GameBoy20.Cards;
using GameBoy20.NumberGuessGame;
using GameBoy20.NumberPokeGame;
using GameBoy20.NumberPokeGame.Messages;
using GameBoy20.Utils.Interfaces;

namespace GameBoy20.Utils
{
    public class GameSelection
    {
        public IGame SelectGame(int gameNumber)
        {
            switch (gameNumber)
            {
                case 1: //create enum for what 1/2/3 is
                    return new PlayNumberGuess(new NumberGuess(new NumberGuessMessages()), new CardDeck());
                case 2:
                    Console.WriteLine("Confirm that GameSelection line 20 is okay.");
                    Console.WriteLine("Confirm that GameSelection line 20 is okay.");
                    Console.WriteLine("Confirm that GameSelection line 20 is okay.");
                    return new PlayNumberPoke(new NumberPoke(new NumberPokeMessages(), new CardDeck()), new CardDeck());
                case 3:
                    return new BlackJack();
                default:
                    break;
            }
            return null;
        }
    }
}
