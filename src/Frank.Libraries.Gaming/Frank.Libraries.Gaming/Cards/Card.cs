using System.Collections;

namespace Frank.Libraries.Gaming.Cards;

public readonly record struct Card(Suit Suit, Rank Rank, int Utf32);

public class Cards : IEnumerable<Card>
{
    public IEnumerator<Card> GetEnumerator()
    {
        // Spades
        yield return new Card(Suit.Spades, Rank.Ace, 0x1F0A1);
        yield return new Card(Suit.Spades, Rank.Two, 0x1F0A2);
        yield return new Card(Suit.Spades, Rank.Three, 0x1F0A3);
        yield return new Card(Suit.Spades, Rank.Four, 0x1F0A4);
        yield return new Card(Suit.Spades, Rank.Five, 0x1F0A5);
        yield return new Card(Suit.Spades, Rank.Six, 0x1F0A6);
        yield return new Card(Suit.Spades, Rank.Seven, 0x1F0A7);
        yield return new Card(Suit.Spades, Rank.Eight, 0x1F0A8);
        yield return new Card(Suit.Spades, Rank.Nine, 0x1F0A9);
        yield return new Card(Suit.Spades, Rank.Ten, 0x1F0AA);
        yield return new Card(Suit.Spades, Rank.Jack, 0x1F0AB);
        yield return new Card(Suit.Spades, Rank.Queen, 0x1F0AD);
        yield return new Card(Suit.Spades, Rank.King, 0x1F0AE);

        // Hearts
        yield return new Card(Suit.Hearts, Rank.Ace, 0x1F0B1);
        yield return new Card(Suit.Hearts, Rank.Two, 0x1F0B2);
        yield return new Card(Suit.Hearts, Rank.Three, 0x1F0B3);
        yield return new Card(Suit.Hearts, Rank.Four, 0x1F0B4);
        yield return new Card(Suit.Hearts, Rank.Five, 0x1F0B5);
        yield return new Card(Suit.Hearts, Rank.Six, 0x1F0B6);
        yield return new Card(Suit.Hearts, Rank.Seven, 0x1F0B7);
        yield return new Card(Suit.Hearts, Rank.Eight, 0x1F0B8);
        yield return new Card(Suit.Hearts, Rank.Nine, 0x1F0B9);
        yield return new Card(Suit.Hearts, Rank.Ten, 0x1F0BA);
        yield return new Card(Suit.Hearts, Rank.Jack, 0x1F0BB);
        yield return new Card(Suit.Hearts, Rank.Queen, 0x1F0BD);
        yield return new Card(Suit.Hearts, Rank.King, 0x1F0BE);

        // Diamonds
        yield return new Card(Suit.Diamonds, Rank.Ace, 0x1F0C1);
        yield return new Card(Suit.Diamonds, Rank.Two, 0x1F0C2);
        yield return new Card(Suit.Diamonds, Rank.Three, 0x1F0C3);
        yield return new Card(Suit.Diamonds, Rank.Four, 0x1F0C4);
        yield return new Card(Suit.Diamonds, Rank.Five, 0x1F0C5);
        yield return new Card(Suit.Diamonds, Rank.Six, 0x1F0C6);
        yield return new Card(Suit.Diamonds, Rank.Seven, 0x1F0C7);
        yield return new Card(Suit.Diamonds, Rank.Eight, 0x1F0C8);
        yield return new Card(Suit.Diamonds, Rank.Nine, 0x1F0C9);
        yield return new Card(Suit.Diamonds, Rank.Ten, 0x1F0CA);
        yield return new Card(Suit.Diamonds, Rank.Jack, 0x1F0CB);
        yield return new Card(Suit.Diamonds, Rank.Queen, 0x1F0CD);
        yield return new Card(Suit.Diamonds, Rank.King, 0x1F0CE);

        // Clubs
        yield return new Card(Suit.Clubs, Rank.Ace, 0x1F0D1);
        yield return new Card(Suit.Clubs, Rank.Two, 0x1F0D2);
        yield return new Card(Suit.Clubs, Rank.Three, 0x1F0D3);
        yield return new Card(Suit.Clubs, Rank.Four, 0x1F0D4);
        yield return new Card(Suit.Clubs, Rank.Five, 0x1F0D5);
        yield return new Card(Suit.Clubs, Rank.Six, 0x1F0D6);
        yield return new Card(Suit.Clubs, Rank.Seven, 0x1F0D7);
        yield return new Card(Suit.Clubs, Rank.Eight, 0x1F0D8);
        yield return new Card(Suit.Clubs, Rank.Nine, 0x1F0D9);
        yield return new Card(Suit.Clubs, Rank.Ten, 0x1F0DA);
        yield return new Card(Suit.Clubs, Rank.Jack, 0x1F0DB);
        yield return new Card(Suit.Clubs, Rank.Queen, 0x1F0DD);
        yield return new Card(Suit.Clubs, Rank.King, 0x1F0DE);
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}