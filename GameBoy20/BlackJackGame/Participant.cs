using System;
using System.Collections.Generic;
using System.Text;

namespace GameBoy20.BlackJackGame
{
    public abstract class Participant
    {
        public int Hand { get; set; }

        public bool Stand { get; set; }

        public string TakeCard()
        {
            Hand = Hand + CardDeck.TakeCard();
            if (Hand == 21)
            {
                return "Blackjack";
            }
            if (Hand > 21)
            {
                return "Bust";
            }
            return "Continue";
        }
    }

}
