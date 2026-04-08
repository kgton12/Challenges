namespace CodeWars.Completed;

public class DefineACardSuit
{
    public static string DefineSuit(string card)
    {
        Dictionary<string, string> deck = new()
        {
            { "♣", "clubs" },
            { "♦", "diamonds" },
            { "♥", "hearts" },
            { "♠", "spades" }
        };

        var suit = card.Length > 0 ? card[^1].ToString() : string.Empty;

        return deck.GetValueOrDefault(suit) ?? string.Empty;
    }
}
