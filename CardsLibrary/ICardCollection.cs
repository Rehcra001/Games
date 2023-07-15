using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsLibrary
{
    public interface ICardCollection
    {
        List<Card> Cards { get; }
        string CollectionName { get; set; }

        void AddCard(Card card);
        void Deal(CardCollection that, int numCards);
        void DealAll(CardCollection that);
        Card GetCardAtIndex(int index);
        int IndexOfCard(Card card);
        int IndexOfLastCard(Card card);
        bool IsEmpty();
        Card PopCard();
        Card PopCardAtIndex(int index);
        void Shuffle();
        int Size();
        void Sort();
        string ToString();
    }
}
