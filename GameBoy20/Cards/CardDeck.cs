﻿using GameBoy20.Cards;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GameBoy20.Cards
{
    public class CardDeck : ICardDeck
    {
        public string TakeCard()
        {
            var cards = new string[] {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", 
                "Queen", "King"};
            var random = new Random();
            var position = random.Next(0, 12);
            return cards.GetValue(position).ToString();
        }

        public string[] TakeHand(int numberOfCards)
        {
            string[] cards = new string[numberOfCards];
            for (var i=0; i<numberOfCards; i++)
            {
                cards[i] = (TakeCard());
            }
            return cards;
        }
    }
}
