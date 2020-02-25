namespace GameBoy20.NumberGuessGame
{
    public interface INumberGuessUi
    {
        public string ObtainGuess();

        public void LoseMessage(string targetCard);
    }
}