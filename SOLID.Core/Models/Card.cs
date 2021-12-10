namespace SOLID.Core.Models;

public class Card
{
    public List<(char, int)> Cards { get; set; }

    public Card()
    {
        var suits = new string("♠♡♢♣").ToList();
        Cards = suits
            .SelectMany(
                _ => Enumerable.Range(1, 13),
                (suit, rank) => (suit, rank))
            .ToList();
    }
}