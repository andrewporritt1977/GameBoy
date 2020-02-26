namespace GameBoy20.NumberGuessGame
{
    public interface INumberGuessUi
    {
        public string ObtainGuess();

        public void ObtainWinConfirmation();

        public void NotifyIncorrectGuess();

        public void NotifyGameLoss(string targetCard);
    }
}