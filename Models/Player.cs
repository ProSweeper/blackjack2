class Player
{
    public List<Card> Hand;
    public int HandValue { get; private set; }
    public bool IsHandShowing { get; private set; }
    public bool IsBlackJack { get; private set; }
    public bool IsBust { get; private set; }

    public Player(bool isDealer)
    {
        Hand = new List<Card>();
        IsHandShowing = !isDealer;
        HandValue = 0;
        IsBlackJack = false;
        IsBust = false;
    }

    public void AddCardToHand(Card card)
    {
        Hand.Add(card);
        updateHandValue();
    }
    private void updateHandValue()
    {
        var aces = 0;
        HandValue = 0;
        foreach (var card in Hand)
        {
            if (card.Name == "A")
            {
                aces++;
            }
            HandValue += card.Value;
        }
        while (HandValue > 21 && aces > 0)
        {
            HandValue -= 10;
            aces--;
        }
        IsBust = HandValue > 21;
        IsBlackJack = HandValue == 21 && Hand.Count == 2;
    }

    public void PrintHand()
    {
        if (IsHandShowing)
        {
            foreach (var card in Hand)
            {
                Console.Write($"[{card.Name}{card.Suit}] ");
            }
            Console.Write($"Value: {HandValue}");
        }
        else
        {
            var card = Hand[0];
            Console.Write($"[{card.Name}{card.Suit}] [//] ");
            Console.Write("Value: ??");
        }
        Console.Write("\n");
    }
}
