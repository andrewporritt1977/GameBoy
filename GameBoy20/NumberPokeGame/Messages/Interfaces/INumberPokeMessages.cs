namespace GameBoy20.NumberPokeGame.Messages.Interfaces
{
    public interface INumberPokeMessages
    {
        public string ObtainCardsToHold();
        public void InformLose();
        public void InformWin();
        public void InformSuperWin();
        public void InformNewLine();
        public void InformCards(Hand hand);

    }
}
