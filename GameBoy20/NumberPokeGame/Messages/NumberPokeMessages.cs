using System;
using GameBoy20.NumberPokeGame.Constants;
using GameBoy20.NumberPokeGame.Messages.Interfaces;

namespace GameBoy20.NumberPokeGame.Messages
{
    internal class NumberPokeMessages : INumberPokeMessages
    {
        public void InformLose()
        {
            Console.WriteLine(NumberPokeUiConstants.LOSE);
        }

        public void InformNewLine()
        {
            Console.WriteLine("");
        }

        public void InformCards(Hand hand)
        {
            Console.WriteLine($"{NumberPokeUiConstants.YOUR_CARDS} {hand.CardOne} {hand.CardTwo} {hand.CardThree}");
        }

        public void InformSuperWin()
        {
            Console.WriteLine(NumberPokeUiConstants.SUPER_WIN);
        }

        public void InformWin()
        {
            Console.WriteLine(NumberPokeUiConstants.WIN);
        }

        public void InformWinStatus(string winStatus)
        {
            Console.WriteLine(winStatus);
        }

        public string ObtainCardsToHold()
        {
            Console.WriteLine(NumberPokeUiConstants.WHICH_CARDS_TO_HOLD);
            return Console.ReadLine();
        }
    }
}
