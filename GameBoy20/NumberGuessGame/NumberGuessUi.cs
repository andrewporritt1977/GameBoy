using System;
using GameBoy20.Utils;

namespace GameBoy20.NumberGuessGame
{
    internal class NumberGuessUi : INumberGuessUi {
        public string ObtainGuess() {
            Console.WriteLine(NumberGuessConstants.GuessNumber);
            Console.WriteLine(NumberGuessConstants.NumberRange);
            return Console.ReadLine();
        }

        public void NotifyGameLoss(string targetCard)
        {
            Console.WriteLine(NumberGuessConstants.Lose);
            Console.WriteLine(NumberGuessConstants.ActualNumber + targetCard);
        }

        public void ObtainWinConfirmation()
        {
            Console.WriteLine(NumberGuessConstants.Win);
            Console.ReadLine();
        }
    }
}