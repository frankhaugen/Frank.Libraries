using System.Collections;

namespace Frank.Libraries.Gaming.Cards;

public class Hand : IEnumerable<Card>
{
    private List<Card> cards = new();

    public IEnumerator<Card> GetEnumerator()
    {
        return cards.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void AddCard(Card card)
    {
        cards.Add(card);
    }

    public int CalculateValue()
    {
        int value = 0;
        int aceCount = 0;

        foreach (Card card in cards)
        {
            if (card.Rank == Rank.Ace)
            {
                value += 11;
                aceCount++;
            }
            else if (card.Rank >= Rank.Ten)
            {
                value += 10;
            }
            else
            {
                value += (int)card.Rank;
            }
        }

        while (value > 21 && aceCount > 0)
        {
            value -= 10;
            aceCount--;
        }

        return value;
    }
}