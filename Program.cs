var deck = new Deck();
var player = new Player(isDealer: false);
var dealer = new Player(isDealer: true);

player.AddCardToHand(deck.DrawCard());
player.AddCardToHand(deck.DrawCard());

dealer.AddCardToHand(deck.DrawCard());
dealer.AddCardToHand(deck.DrawCard());

dealer.PrintHand();
player.PrintHand();

