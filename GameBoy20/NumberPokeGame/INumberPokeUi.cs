using System;
using System.Collections.Generic;
using System.Text;

namespace GameBoy20.NumberPokeGame
{
    public interface INumberPokeUi
    {
        public void InformYourCards(string[] cards);

        public string ObtainCardsToHold();

        public void InformWinStatus(string winStatus);

        public void InformLose();

        public void InformWin();

        public void InformSuperWin();

        public void InformNewLine();
    }
}
