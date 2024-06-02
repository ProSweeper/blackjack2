class Game
{
    private Player player;
    private Player dealer;
    private Deck deck;

    public Game()
    {
        player = new Player(false);
        dealer = new Player(true);
        deck = new Deck();
    }

    private void dealerTurn()
    {
        while (dealer.HandValue < 17)
        {
            dealer.AddCardToHand(deck.DrawCard());
        }
    }

    private void determineWinner()
    {
        if (player.HandValue > dealer.HandValue)
        {
            Console.WriteLine("Player Wins");
        }
        else if (dealer.HandValue > player.HandValue)
        {
            Console.WriteLine("Dealer Wins");
        }
        else
        {
            Console.WriteLine("Push");
        }
    }
}
