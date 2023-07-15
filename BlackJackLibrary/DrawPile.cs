using CardsLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackLibrary
{
    public class DrawPile : CardCollection
    {
        private const int NUMBER_OF_SUITS = 4; //Hearts, Diamonds, Clubs, Spades
        private const int NUMBER_OF_RANKS = 13; //Ace, Two,..., King
        

        public DrawPile(string name = "Draw Pile", int numberOfDecks = 6) : base(name)
        {
            this.CollectionName = name;
            for (int k = 0; k < numberOfDecks; k++)
            {
                for (int i = 0; i < NUMBER_OF_SUITS; i++)
                {
                    for (int j = 0; j < NUMBER_OF_RANKS; j++)
                    {
                        Card card = new Card((CardEnums.Suits)i, (CardEnums.Ranks)j);
                        if (card.Rank >= CardEnums.Ranks.Ten)
                        {
                            card.Value = 10;
                        }
                        else
                        {
                            card.Value = (int)card.Rank + 1;
                        }
                        this.Cards.Add(card);
                    }
                }
            }
        }
    }
}
