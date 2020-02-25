using System;
using System.Collections.Generic;
using System.Text;

namespace GameBoy20.BlackJackGame
{
    public static class CardDeck
    {
        
        public static string TakeCard()
        {
            var cards = new string[] {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", 
                "Queen", "King"};
            var random = new Random();
            var position = random.Next(0, 12);
            return cards.GetValue(position).ToString();
        }

    }
}
