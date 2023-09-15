// See https://aka.ms/new-console-template for more information

using Stacks_Sawyer_Moira;
// Card array with Card objects.
Card[] myCardsArray = new Card[]
{
     new Card("Ace", "Spades"),
     new Card("Jack", "Clubs"),
     new Card("Queen", "Diamonds"),
     new Card("King", "Diamonds"),
     new Card("10", "Hearts"),
     new Card("2", "Diamonds"),
     new Card("6", "Spades"),
     new Card("9", "Clubs"),
     new Card("Ace", "Diamonds")
};
// Loops through the stacks and prints on a new line for each card.
Stack<Card> startingDeck = new Stack<Card>(myCardsArray);
// Prints to the console, "Cards in deck:".
Console.WriteLine("Cards in Deck");
foreach(Card card in startingDeck)
{
    Console.WriteLine($"The {card.Number} of {card.Suit}!");
}
// Prints the number of cards in the deck.
Console.WriteLine($"Cards in the deck: {startingDeck.Count}"); 
// Prints the 3 different Cards to myHand.
List<Card> myHand = new List<Card>();
myHand.Add(new Card("Jack", "Diamonds"));
myHand.Add(new Card("8", "Hearts"));
myHand.Add(new Card("3", "Diamonds"));
// Prints to the console "Got any 8's?".
Console.WriteLine("Got any 8's?");
// Adds to myHand from the deck.
if(startingDeck.Count > 0)
{
    myHand.Add(startingDeck.Pop());
}
// Prints to the console, "Cards in deck:".
Console.WriteLine($"Cards in the deck: {startingDeck.Count}");
// Prints the number of cards in the deck.
startingDeck.Push(myHand[0]);
myHand.RemoveAt(0);
// Loops through the stacks and prints on a new line for each card.
Console.WriteLine("Cards in Deck");
foreach (Card card in startingDeck)
{
    Console.WriteLine($"The {card.Number} of {card.Suit}!");
}
