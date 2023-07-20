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

        //If images are required
        private const int CARD_COLUMNS = 13;
        private const int CARD_ROWS = 5;
        private string imagePath;

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

        /// <summary>
        /// Add card images to the drawpile
        /// </summary>
        /// <param name="imagePath"></param>
        /// <param name="name"></param>
        /// <param name="numberOfDecks"></param>
        public DrawPile(Image cardsImage, string name = "Draw Pile", int numberOfDecks = 6) : base(name)
        {
            this.CollectionName = name;

            List<Image> cardImages = AddCardImages(cardsImage);

            for (int k = 0; k < numberOfDecks; k++)
            {
                int count = 0;
                for (int i = 0; i < NUMBER_OF_SUITS; i++)
                {
                    for (int j = 0; j < NUMBER_OF_RANKS; j++)
                    {
                        Card card = new Card((CardEnums.Suits)i, (CardEnums.Ranks)j);
                        if (card.Rank >= CardEnums.Ranks.Ten)
                        {
                            card.Value = 10;
                            card.CardImage = cardImages[count++];
                        }
                        else
                        {
                            card.Value = (int)card.Rank + 1;
                            card.CardImage = cardImages[count++];
                        }
                        this.Cards.Add(card);
                    }
                }
            }
        }

        private List<Image> AddCardImages(Image cardsImage)
        {
            List<Image> cardImages = new List<Image>();
            try
            {
                //int xMargin = 10;
                //int yMargin = 13;
                //int colSpacingBetweenCards = 10;
                //int rowSpacingBetweenCards = 13;
                int cardWidth = (cardsImage.Width / CARD_COLUMNS);// - (colSpacingBetweenCards);
                int cardHeight = (cardsImage.Height / CARD_ROWS);// - (rowSpacingBetweenCards);
                int x = 0;
                int y = 0;


                for (int i = 0; i < CARD_ROWS; i++)
                {
                    
                    for (int j = 0; j < CARD_COLUMNS; j++)
                    {
                        
                        Bitmap source = new Bitmap(cardsImage);
                        Rectangle rectangle = new Rectangle(x, y, cardWidth, cardHeight);
                        Image cardImage = source.Clone(rectangle, source.PixelFormat);
                        cardImages.Add(cardImage);
                        source.Dispose();
                        x += cardWidth;
                    }
                    y += cardHeight;
                    x = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problem retrieving card image!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return cardImages;
        }
    }
}