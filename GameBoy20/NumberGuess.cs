using System;
using System.Collections.Generic;
using System.Text;

namespace GameBoy20
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
    class NumberGuess
    {

    }
}
