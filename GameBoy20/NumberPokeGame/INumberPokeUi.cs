using System;
using System.Collections.Generic;
using System.Text;

namespace GameBoy20.NumberPokeGame
{
    public interface INumberPokeUi
    {
        public void InformYourCards(string cardOne, string cardTwo, string cardThree);

        public string ObtainCardsToHold();

        public void InformWinStatus(string winStatus);
    }
}
