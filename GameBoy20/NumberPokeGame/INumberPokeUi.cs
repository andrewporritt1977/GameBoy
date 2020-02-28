using System;
using System.Collections.Generic;
using System.Text;

namespace GameBoy20.NumberPokeGame
{
    public interface INumberPokeUi
    {
        public string ObtainCardsToHold();
        public void InformLose();
        public void InformWin();
        public void InformSuperWin();
        public void InformNewLine();
        public void InformCards(Hand hand);

    }
}
