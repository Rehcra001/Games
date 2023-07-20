using CardsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackLibrary
{
    public class BlackJackHand : CardCollection
    {
        /// <summary>
        /// Hand value count = 0 if there are no
        /// valid hand values - ie. all possible 
        /// values are greater than 21
        /// </summary>
        public List<int> HandValue { get; private set; }
        public string Status { get; private set; } = "Empty Hand";
        public bool DoubleDown { get; set; } = false;

        private int numberOfAces = 0;
        private bool hasDoubledDown = false;

        public BlackJackHand(string player) : base(player)
        {
            HandValue = new List<int>();
        }

        public override void AddCard(Card card)
        {
            if (!DoubleDown)
            {
                if (card.Rank == CardEnums.Ranks.Ace)
                {
                    numberOfAces += 1;
                }
                this.Cards.Add(card);
                CalcHandValue();
            }
            else
            {
                if (!hasDoubledDown)
                {
                    int ddValue = 0;
                    //Search for the double down index (one card maybe an ace)
                    for (int i = 0; i < HandValue.Count; i++)
                    {
                        if (HandValue[i] == 10 || HandValue[i] == 11)
                        {
                            ddValue = HandValue[i];
                            break;
                        }
                    }
                    if (card.Rank == CardEnums.Ranks.Ace)
                    {
                        //two values
                        //one
                        HandValue = new List<int>();
                        if (ddValue + 1 <= 21)
                        {
                            HandValue.Add(ddValue + 1);
                        }
                        //eleven
                        if (ddValue + 11 <= 21)
                        {
                            HandValue.Add(ddValue + 11);
                        }
                        this.Cards.Add(card);
                        hasDoubledDown = true;
                    }
                    else
                    {
                        //one value
                        HandValue = new List<int>();
                        HandValue.Add(ddValue + card.Value);
                        this.Cards.Add(card);
                        hasDoubledDown = true;
                    }
                }
            }
            
        }

        /// <summary>
        /// Removes and returns a card from this collection at the given index 
        /// For blackjack this will happen when splitting a hand
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public override Card PopCardAtIndex(int index)
        {
            if (!IsEmpty())
            {
                Card card = this.Cards[index];
                this.Cards.RemoveAt(index);
                //Recalculate the hand value as their is one less card
                if (card.Rank == CardEnums.Ranks.Ace)
                {
                    numberOfAces--;
                }
                CalcHandValue();
                return card;
            }
            else
            {
                return null;
            }

        }

        /// <summary>
        /// Dicards and resets this blackjack hand
        /// </summary>
        /// <param name="that"></param>
        public void DiscardHand(CardCollection that)
        {
            //Empty hand
            this.DealAll(that);
            //Reset hand value/s
            HandValue.Clear();
            //Reset number of Aces
            numberOfAces = 0;
        }

        /// <summary>
        /// Calculates the value of this blackjack hand.
        /// Taking into account that Ace's can have two values
        /// </summary>
        private void CalcHandValue()
        {
            //Clear hand value/s
            HandValue.Clear();

            //For each Ace in the hand the hand has two values
            //one where the Ace has a value of one
            //and one where the Ace has a value of eleven
            if (numberOfAces > 0)
            {
                //Get the value of non Ace cards
                int val = 0;
                foreach (Card card in this.Cards)
                {
                    if (card.Rank != CardEnums.Ranks.Ace)
                    {
                        val += card.Value;
                    }
                }
                //Calculate the values of each Ace or Combinations of them
                List<int>[] aceValues = new List<int>[numberOfAces + 1];
                aceValues[0] = new List<int>();
                aceValues[0].Add(0);
                for (int i = 1; i <= numberOfAces; i++)
                {
                    aceValues[i] = new List<int>();
                    for (int j = 0; j < aceValues[i -  1].Count; j++)
                    {
                        aceValues[i].Add(aceValues[i - 1][j] + 1 );
                        aceValues[i].Add(aceValues[i - 1][j] + 11);
                    }
                }
                aceValues[numberOfAces].Sort();
                //Only add the unique hand values to HandValue
                //from the last row
                if (aceValues[numberOfAces][0] + val <= 21)
                {
                    HandValue.Add(aceValues[numberOfAces][0] + val);
                }
                
                for (int i = 1; i < aceValues[numberOfAces].Count; i++)
                {
                    if (aceValues[numberOfAces][i] + val <= 21)
                    {
                        if (aceValues[numberOfAces][i] != aceValues[numberOfAces][i - 1])
                        {
                            HandValue.Add(aceValues[numberOfAces][i] + val);
                        }
                    }
                }
                if (HandValue.Count == 0 || HandValue == null)
                {
                    Status = "Bust";
                }
                else
                {
                    Status = "In Play";
                }
            }
            else
            {
                int val = 0;
                foreach (Card card in this.Cards)
                {
                    if (card.Rank != CardEnums.Ranks.Ace)
                    {
                        val += card.Value;
                    }
                }
                if (val <= 21)
                {
                    Status = "In Play";
                    HandValue.Add(val);
                }
                else
                {
                    Status = "Bust";
                }
            }
        }

        public override string ToString()
        {
            if (HandValue == null)
            {
                return "";
            }
            else
            {
                return String.Join(", ", HandValue);
            }
        }
    }
}
