using GameBoy20.NumberGuessGame;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameTest.Spec
{
    public class MockNumberGuessUi : INumberGuessUi
    {
        public string CardReturn { get; set; }

        public void NotifyGameLoss(string targetCard)
        {
           
        }

        public string ObtainGuess()
        {
            return CardReturn;
        }

        public void ObtainWinConfirmation()
        {
            
        }
    }
}
