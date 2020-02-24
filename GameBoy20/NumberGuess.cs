using System;
using System.Collections.Generic;
using System.Text;
using GameBoy20.Utils;

namespace GameBoy20.NumberGuessGame
{


    //Game Setup
    class Setup
    {
        public int Target { get; set; }

        public int Round { get; set; }

        public int Guess { get; set; }

        public string Result()
        {
            if (Guess == Target)
            {
                return "Win";
            }
            else
            {
                return "Lose";
            }
        }

        public int NumberGuess()
        {
            Random rando = new Random();
            return rando.Next(1, 10);
        }


    }
    // Game Logic
    class NumberGuess : IGame
    {
        public void LaunchGame()
        {
            // Setup new game
            Setup setup = new Setup();

            setup.Target = setup.NumberGuess();

            Console.WriteLine(setup.Target);
            
        }
    }
}
