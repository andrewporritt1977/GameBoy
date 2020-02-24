using System.Collections.Generic;
using System.Linq;
using GameBoy20.BlackJackGame;

namespace GameBoy20.NumberPoke
{
    class NumberPoke
    {
        public string CardOne { get; set; }
        public string CardTwo { get; set; }
        public string CardThree { get; set; }
        
        private bool CardOneHeld { get; set; }
        private bool CardTwoHeld { get; set; }
        private bool CardThreeHeld { get; set; }

        public void DrawCards()
        {
            if (!CardOneHeld) CardOne = CardDeck.TakeCard();
            if (!CardTwoHeld) CardTwo = CardDeck.TakeCard();
            if (!CardThreeHeld) CardThree = CardDeck.TakeCard();
        }

        public void HoldCards(string heldCardsString)
        {
            List<int> heldCards = heldCardsString.Split(',').Select(int.Parse).ToList();
            foreach (var card in heldCards)
            {
                switch (card) 
                {
                    case 1:
                        CardOneHeld = true;
                        break;
                    case 2:
                        CardTwoHeld = true;
                        break;
                    case 3:
                        CardThreeHeld = true;
                        break;
                }
            }
        }

        public string WinStatus()
        {
            if (CardOne == CardTwo && CardTwo == CardThree)
            {
                return "Super-win";
            }
            if (CardOne == CardTwo || CardTwo == CardThree || CardOne == CardThree)
            {
                return "Win";
            }
            return "Lose";
        }
    }
}
