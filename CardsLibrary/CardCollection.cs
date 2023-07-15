using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CardsLibrary
{
    public class CardCollection : ICardCollection
    {
        public List<Card> Cards { get; }

        public string CollectionName { get; set; }


        public CardCollection (string name)
        {
            this.Cards = new List<Card>();
            this.CollectionName = name;
        }

        /// <summary>
        /// Adds a card to this card collection
        /// </summary>
        /// <param name="card"></param>
        public virtual void AddCard(Card card)
        {
            this.Cards.Add(card);
        }

        /// <summary>
        /// Moves numCards from this card collection to that card collection
        /// </summary>
        /// <param name="that"></param>
        /// <param name="numCards"></param>
        public virtual void Deal(CardCollection that, int numCards = 1)
        {
            for (int i = 0; i < numCards; i++)
            {
                that.AddCard(this.PopCard());
                
            }
        }

        /// <summary>
        /// Moves all the Cards from this Card Collection to that Card Collection
        /// </summary>
        /// <param name="that"></param>
        public virtual void DealAll(CardCollection that)
        {
            while (this.Size() > 0)
            {
                that.AddCard(this.PopCard());
            }
        }

        /// <summary>
        /// Returns the card in this collection at the given index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Card GetCardAtIndex(int index)
        {
            if (!IsEmpty())
            {
                return this.Cards[index];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Returns the index of the first card in the collection that matches
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public int IndexOfCard(Card card)
        {
            for (int i = 0; i < this.Size(); i++)
            {
                if (this.Cards[i].CompareTo(card) == 0)
                {
                    return i;
                }
            }
            return -1;
        }


        /// <summary>
        /// Returns the index of the last card in the collection that matches
        /// </summary>
        /// <returns></returns>
        public int IndexOfLastCard(Card card)
        {
            for (int i = this.Size() - 1; i >= 0; i--)
            {
                if (this.Cards[i].CompareTo(card) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Checks if the Card Collection is empty or not
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return this.Cards.Count == 0;
        }

        /// <summary>
        /// Removes and returns the last card in this Card Collection
        /// If the collection is empty it returns null.
        /// </summary>
        /// <returns></returns>
        public Card PopCard()
        {
            if (!this.IsEmpty())
            {
                int index = this.Size() - 1;
                Card card = this.Cards[index];
                this.Cards.RemoveAt(index);
                return card;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Removes and returns a card from this collection at the given index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public virtual Card PopCardAtIndex (int index)
        {
            if (!IsEmpty())
            {
                Card card = this.Cards[index];
                this.Cards.RemoveAt(index);
                return card;
            }
            else
            {
                return null;
            }
            
        }

        /// <summary>
        /// Shuffles this collection of cards
        /// </summary>
        public void Shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < this.Size() - 1; i++)
            {
                int rand = random.Next(this.Size());
                (this.Cards[i], this.Cards[rand]) = (this.Cards[rand], this.Cards[i]);
            }
        }

        /// <summary>
        /// Returns the number of Cards in this Card Collection
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return this.Cards.Count;
        }

        /// <summary>
        /// Sorts this collection of cards using Card.CompareTo
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Sort()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the ToString of Cards in this Card Collection
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (!IsEmpty())
            {
                string description = this.CollectionName + ":\r\n";
                for (int i = 0; i < this.Size(); i++)
                {
                    if (i < this.Size() - 1)
                    {
                        description += this.Cards[i].ToString() + "\r\n";
                    }
                    else
                    {
                        description += this.Cards[i].ToString();
                    }                    
                }
                return description;
            }
            else
            {
                return $"No Cards in {CollectionName}";
            }
        }
    }
}
