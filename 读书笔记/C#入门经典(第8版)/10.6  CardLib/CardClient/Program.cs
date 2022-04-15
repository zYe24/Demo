using CardLib.Models;

Deck currentDeck = new Deck();
ShowDeck(currentDeck);
Console.WriteLine("===========================");

currentDeck.Shuffle();
ShowDeck(currentDeck);
Console.WriteLine("===========================");

currentDeck.Shuffle2();
ShowDeck(currentDeck);
Console.WriteLine("===========================");


void ShowDeck(Deck deck)
{
    for(int i = 0; i < 52; i++)
    {
        Card card = deck.GetCard(i);
        Console.Write(card);
        if (i == 51) Console.WriteLine();
        else Console.Write(", ");
    }
}

