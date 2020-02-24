using System;
using System.Collections.Generic;
using System.Text;
using GameBoy20.BlackJackGame;

namespace GameBoy20
{
    class NumberPoke
    {
        public int CardOne { get; set; }
        public int CardTwo { get; set; }
        public int CardThree { get; set; }
        
        public bool CardOneHeld { get; set; }
        public bool CardTwoHeld { get; set; }
        public bool CardThreeHeld { get; set; }

        public void DrawCards()
        {
            if (!CardOneHeld) CardOne = CardDeck.TakeCard();
            if (!CardTwoHeld) CardTwo = CardDeck.TakeCard();
            if (!CardThreeHeld) CardThree = CardDeck.TakeCard();
        }

        public void HoldCards(string heldCards)
        {
            
        }
    }
}
