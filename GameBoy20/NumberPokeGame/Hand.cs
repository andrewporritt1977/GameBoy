using GameBoy20.NumberPokeGame.Enums;

namespace GameBoy20.NumberPokeGame
{
    public class Hand
    {
        public Hand(string[] cards)
        {
            CardOne = cards[0];
            CardTwo = cards[1];
            CardThree = cards[2];
        }
        
        public string CardOne { get; set; }
        public string CardTwo { get; set; }
        public string CardThree { get; set; }
        
        public GameResultEnum GetWinStatus()
        {
            if (CardOne == CardTwo && CardOne == CardThree)
            {
                return GameResultEnum.SuperWin;
            } 
            if (CardOne == CardTwo || CardTwo == CardThree || CardOne == CardThree)
            {
                return GameResultEnum.Win;
            }
            return GameResultEnum.Lose;
        }
    }
}