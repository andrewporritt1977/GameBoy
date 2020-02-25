using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameBoy20.BlackJackGame
{
    public abstract class Participant
    {
        public List<string> Hand = new List<string>();

        public bool Stand { get; set; }

        public int HandTotal()
        {
            int total = 0;
            foreach (var Card in Hand)
            {
                if (Card.All(char.IsDigit)) total = total + Int32.Parse(Card);
                else total = total + (int)Enum.Parse(typeof(CardNumbers), Card);
            }
            //ace calculation
            int aceCount = 0;
            foreach (var card in Hand)
            {
                if (card == "Ace") aceCount++;
            }

            for (var i = 0; i < aceCount; i++)
            {
                if ((total + 10) < 21) total = total + 10;
            }
            return total;
        }

        public string HandContents()
        {
            return string.Join(", ", Hand.ToArray());
        }
        public string TakeCard()
        {
            var card = CardDeck.TakeCard();
            Hand.Add(card);
            if (HandTotal() == 21)
            {
                return "Blackjack";
            }
            if (HandTotal() > 21)
            {
                return "Bust";
            }
            return "Continue";
        }
    }

}
