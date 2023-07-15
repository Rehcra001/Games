using static CardsLibrary.CardEnums;

namespace CardsLibrary
{
    public class Card : ICard
    {
        public Suits Suit { get; }
        public Ranks Rank { get; }
        public int Value { get; set; }
        public Image CardImage { get; set; }

        public Card(Suits suit, Ranks rank)
        {
            this.Suit = suit;
            this.Rank = rank;
        }

        public Card(Suits suit, Ranks rank, int cardValue)
        {
            this.Suit = suit;
            this.Rank = rank;
            this.Value = cardValue;
        }

        public Card (Suits suit, Ranks rank, Image cardImage)
        {
            this.Suit = suit;
            this.Rank = rank;
            this.CardImage = cardImage;
        }

        public Card(Suits suit, Ranks rank, int cardValue, Image cardImage)
        {
            this.Suit = suit;
            this.Rank = rank;
            this.Value = cardValue;
            this.CardImage = cardImage;
        }

        public override string ToString()
        {
            return $"{this.Rank} of {this.Suit}";
        }

        public int CompareTo(Card that)
        {
            if (this.Suit > that.Suit)
            {
                return 1;
            }
            else if (this.Suit < that.Suit)
            {
                return -1;
            }
            else if (this.Rank > that.Rank)
            {
                return 1;
            }
            else if (this.Rank < that.Rank)
            {
                return -1;
            }
            else
            {
                //Both Suit and Rank are the same
                return 0;
            }
            
        }
    }
}
