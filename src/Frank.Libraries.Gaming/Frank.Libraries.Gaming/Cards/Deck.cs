using System.Collections;

namespace Frank.Libraries.Gaming.Cards;

public class Deck : IEnumerable<Card>
{
    private List<Card> _cards;

    public Deck()
    {
        _cards = new List<Card>();
        _cards.AddRange(new Cards());
    }

    public IEnumerator<Card> GetEnumerator() => _cards.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void Shuffle() => _cards = _cards.OrderBy(_ => Random.Shared.Next()).ToList();

    public Card Draw()
    {
        var card = _cards.First();
        _cards.Remove(card);
        return card;
    }
}