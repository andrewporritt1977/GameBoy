using System;
using System.Collections.Generic;
using System.Text;

namespace GameBoy20.BlackJackGame
{
    public class Dealer : Participant
    {
        public Dealer()
        {
            Random random = new Random();
            HiddenCard = CardDeck.TakeCard();
        }

        public int HiddenCard { get; set; }
    }

}
