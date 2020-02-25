namespace GameBoy20.NumberGuessGame
{
    public interface INumberGuessUi
    {
        public string ObtainGuess();

        public void ObtainWinConfirmation();

        public void NotifyGameLoss(string targetCard);
    }
}