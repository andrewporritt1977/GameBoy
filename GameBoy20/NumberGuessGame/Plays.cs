using System;
using System.Collections.Generic;
using System.Text;

namespace GameBoy20.NumberGuessGame
{
    class Plays
    {
        public Plays()
        {
            PlaysLeft = 5;
            Win = false;
        }

        public int PlaysLeft { get; set;}
        public bool Win { get; set; }
    }
}
