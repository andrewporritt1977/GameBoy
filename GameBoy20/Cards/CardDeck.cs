using System;
using System.Collections.Generic;
using System.Text;

namespace GameBoy20.BlackJackGame
{
    public static class CardDeck
    {
        public static int TakeCard()
        {
            Random random = new Random();
            return random.Next(1, 11);
        }

    }
}
