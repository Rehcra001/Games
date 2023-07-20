using CardsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackLibrary
{
    public class Dealer
    {
        public BlackJackHand Hand { get; set; }
        public string Name { get; }
        public string Status { get; private set; }

        private const int MAX_CARDS_TO_DEAL = 2;
        private bool hasDealt = false;


        public Dealer(string name)
        {
            Name = name;
            Hand = new BlackJackHand(Name);
            Status = "Play";
        }

        /// <summary>
        /// By dicarding the dealers hand all hands in the game will
        /// be discarded
        /// </summary>
        /// <param name="discardPile"></param>
        /// <param name="players"></param>
        public void Discard(CardCollection discardPile, Player[] players)
        {
            //Discard dealers hand
            Hand.DiscardHand(discardPile);
            //Reset Hand
            Hand = new BlackJackHand(Name);
            //Reset Status
            Status = "Play";
            DiscardPlayer(discardPile, players);
        }

        public void DealAll(DrawPile drawPile, Player[] players)
        {
            if (!hasDealt)
            {
                for (int i = 0; i < MAX_CARDS_TO_DEAL; i++)
                {
                    //Dealer gets a card first
                    drawPile.Deal(this.Hand);
                    foreach (Player player in players)
                    {
                        if (player != null && player.BetPot[player.CurrentHand].PotValue > 0)
                        {
                            player.DealInitialHand(drawPile);
                        }

                    }
                }
                SetStatus();
                hasDealt = true;
            }
            
        }

        public void HitPlayer(DrawPile drawPile, Player player)
        {
            player.Hit(drawPile);
        }

        public void Stay()
        {
            SetStatus();
            if (Status != "BlackJack")
            {
                Status = "Stay";
            }
            
        }

        public void Play(DrawPile drawPile)
        {
            if (!Status.Equals("Stay"))
            {
                SetStatus();
                while (Status.Equals("Play"))
                {
                    drawPile.Deal(Hand);
                    SetStatus();
                }
            }
        }

        /// <summary>
        /// Discards all the players hands
        /// </summary>
        /// <param name="discardPile"></param>
        /// <param name="players"></param>
        private void DiscardPlayer(CardCollection discardPile, Player[] players)
        {
            foreach (Player player in players)
            {
                if (player != null)
                {
                    player.Discard(discardPile);
                }
            }
            hasDealt = false;
        }

        public override string ToString()
        {
            string dealerStatus = $"{Name}:\r\n\r\n";
            dealerStatus += "Cards: \r\n" + Hand.ToString() + "\r\n";
            dealerStatus += "Hand Value: " + String.Join(":", Hand.HandValue) + "\r\n";
            dealerStatus += $"Status: {Status}\r\n\r\n";
            return dealerStatus;
        }

        private void SetStatus()
        {
            if (!Hand.Status.Equals("Bust"))
            {
                switch (Hand.HandValue.Max())
                {
                    case < 17:
                        Status = "Play";
                        break;
                    case < 21:
                        Status = "Stay";
                        break;
                    case 21:
                        if (Hand.Cards.Count == 2)
                        {
                            Status = "BlackJack";
                            break;
                        }
                        else
                        {
                            Status = "Stay";
                            break;
                        }
                }
            }
            else
            {
                Status = "Bust";
            }
            
        }
    }
}
