using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsLibrary
{
    public class Deck : CardCollection
    {
        private const int NUMBER_OF_SUITS = 4; //Hearts, Diamonds, Clubs, Spades
        private const int NUMBER_OF_RANKS = 13; //Ace, Two,..., King

        /// <summary>
        /// A standard deck of Cards contains 52 cards one for each suit and rank
        /// </summary>
        /// <param name="name"></param>
        public Deck(string name) : base(name)
        {
            for (int i = 0; i < NUMBER_OF_SUITS; i++)
            {
                for (int j = 0; j < NUMBER_OF_RANKS; j++)
                {
                    Card card = new Card((CardEnums.Suits)i ,(CardEnums.Ranks)j);
                    this.Cards.Add(card);
                }
            }
        }
    }
}
