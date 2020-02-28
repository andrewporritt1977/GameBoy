namespace GameBoy20.NumberPokeGame
{
    public class Hand
    {
        public string CardOne { get; set; }
        public string CardTwo { get; set; }
        public string CardThree { get; set; }
        
        public int GetWinStatus()
        {
            if (CardOne == CardTwo && CardOne == CardThree)
            {
                return 1;
            } 
            if (CardOne == CardTwo || CardTwo == CardThree || CardOne == CardThree)
            {
                return 2;
            }

            return 3;

        }
    }
}