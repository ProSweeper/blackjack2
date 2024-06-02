class Deck
{
    private List<Card> cards;
    private string[] suits = { "♡", "♣", "♦", "♠" };
    private string[] cardRanks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
    public Deck()
    {
        cards = shuffleDeck(generateNewDeck());
    }

    private List<Card> generateNewDeck()
    {
        var cardDeck = new List<Card>();
        foreach (var suit in suits)
        {
            foreach (var cardRank in cardRanks)
            {
                cardDeck.Add(new Card(cardRank, suit, getCardValue(cardRank)));
            }
        }
        return cardDeck;
    }

    private int getCardValue(string cardRank)
    {
        if ("JQK".Contains(cardRank))
        {
            return 10;
        }
        if (cardRank == "A")
        {
            return 11;
        }
        else
        {
            return int.Parse(cardRank);
        }
    }

    private static Random rng = new Random();

    private List<Card> shuffleDeck(List<Card> cards)
    {
        return cards.OrderBy(_ => rng.Next()).ToList();
    }

    public void PrintDeck()
    {
        foreach (var card in cards)
        {
            Console.WriteLine($"{card.Name} of {card.Suit} has a value of {card.Value}.");
        }
    }

    public Card DrawCard()
    {
        var card = cards[0];
        cards.RemoveAt(0);
        return card;
    }
}
