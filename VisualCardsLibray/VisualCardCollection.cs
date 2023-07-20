using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace VisualCardsLibray
{
    public class VisualCardCollection
    {
        public List<VisualCard> VisualCards { get; }

        //public string CollectionName { get; }

        public VisualCardCollection()
        {
            this.VisualCards = new List<VisualCard>();
        }

        /// <summary>
        /// Add a visual card to the collection
        /// </summary>
        /// <param name="vCard"></param>
        public void AddVCard(VisualCard vCard)
        {
            this.VisualCards.Add(vCard);
        }

        /// <summary>
        /// Show all the visual cards in the collection
        /// </summary>
        public void ShowVCards()
        {
            foreach (VisualCard vCard in VisualCards)
            {
                vCard.Visible = true;
            }
        }

        /// <summary>
        /// Hide all the visual cards in the collection
        /// </summary>
        public void HideVCards()
        {
            foreach (VisualCard vCard in VisualCards)
            {
                vCard.Visible = false;
            }
        }

        /// <summary>
        /// Will make the first not visible visual card found visible
        /// </summary>
        public void ShowNextVCard()
        {
            foreach (VisualCard vCard in VisualCards)
            {
                //if the visual card is not visible
                if (!vCard.Visible)
                {
                    vCard.Visible = true;
                    break;
                }
            }
        }

        public VisualCard PopVCard()
        {
            VisualCard vCard = VisualCards[VisualCards.Count - 1];
            VisualCards.RemoveAt(VisualCards.Count - 1);
            return vCard;
        }
    }
}
