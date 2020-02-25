using System;
using System.Collections.Generic;
using System.Text;
using GameBoy20.Utils;

namespace GameBoy20.NumberGuessGame
{
    // Game Logic
    public class NumberGuess : IGame
    {
        private NumberGuessUI _ui;

        public NumberGuess(NumberGuessUI ui)
        {
            _ui = ui;
        }

        public void LaunchGame()
        {


            // Setup new game
            RandomCard randomCard = new RandomCard();

            Plays plays = new Plays();

            while (!plays.Win && plays.PlaysLeft > 0)
            {
                if(randomCard.PlayRound(_ui.ObtainGuess()))
                {
                    Console.WriteLine(NumberGuessConstants.Win);
                    Console.ReadLine();
                    return;
                }

                plays.PlaysLeft--;
                Console.WriteLine("plays left - " + plays.PlaysLeft);
            }

            Console.WriteLine(NumberGuessConstants.Lose);
            Console.WriteLine(NumberGuessConstants.ActualNumber + randomCard.Target);

        }
    }

    public class NumberGuessUI {

        public string ObtainGuess() {
            Console.WriteLine(NumberGuessConstants.GuessNumber);
            Console.WriteLine(NumberGuessConstants.NumberRange);
            return Console.ReadLine();
        }
    }
}
