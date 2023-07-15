using static CardsLibrary.CardEnums;

namespace CardsLibrary
{
    public interface ICard
    {
        public Suits Suit { get; }
        public Ranks Rank { get; }
        public int Value { get; set; }

        int CompareTo(Card that);
        string ToString();
    }
}