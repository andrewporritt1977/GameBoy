using System;
using System.Collections.Generic;
using System.Text;
using GameBoy20.Utils;

namespace GameBoy20.NumberGuessGame
{


    //Game Setup
    class NumberGuessSetup
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
    }
    // Game Logic
    class NumberGuess : IGame
    {
        public void LaunchGame()
        {
            Console.WriteLine("Success!!!!");
        }
    }
}
