using CardsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackLibrary
{
    
    public class Player
    {
        public List<BlackJackHand> Hand { get; set; }
        public PlayerPot Pot { get; set; }
        public string Name { get; }
        public int CurrentHand { get; set; }
        public List<PlayerPot> BetPot { get; set; } // one per hand
        public List<string> PlayerStatus { get; private set; } //BlackJack, Stay, Bust, Playing, Waiting
        public bool CanSplit { get; private set; } = false; //Can split if the two initial cards are of the same value one the first deal
        public bool CanDoubleDown { get; private set; } = false;

        private List<bool> isStay;        
        private bool isSplit = false; //Set true if player splits
        private bool initialHandDealt = false;
        private int doubleDownIndex;

        public Player(string playerName)
        {
            Name = playerName;
            PlayerStatus = new List<string>();
            PlayerStatus.Add("Waiting");
            Hand = new List<BlackJackHand>();
            Hand.Add(new BlackJackHand(Name + "-1")); //first hand
            Pot = new PlayerPot();
            CurrentHand = 0;
            BetPot = new List<PlayerPot>();
            BetPot.Add(new PlayerPot()); //Betting on the first hand
            isStay = new List<bool>();
            isStay.Add(false);
        }

        public void Bet(int amount)
        {
            if (Pot.PotValue > 0)
            {
                //Remove from the players pot
                Pot.RemoveFromPot(amount);
                //Add to the players current betting pot
                BetPot[CurrentHand].AddToPot(amount);
                PlayerStatus[CurrentHand] = "Play";
            }
            else
            {
                MessageBox.Show("Nothing left in your pot to bet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Will do the initial deal of a max of two cards
        /// then sets initialHandDealt to true;
        /// </summary>
        /// <param name="drawPile"></param>
        /// <param name="card"></param>
        public void DealInitialHand(DrawPile drawPile)
        {
            if (BetPot[CurrentHand].PotValue > 0)
            {
                if (!initialHandDealt)
                {
                    drawPile.Deal(Hand[CurrentHand]);
                    if (Hand[CurrentHand].Cards.Count == 2)
                    {
                        initialHandDealt = true;
                        //Check for BlackJack
                        if (Hand[CurrentHand].HandValue.Max() == 21)
                        {
                            //then blackjack
                            PlayerStatus[CurrentHand] = "BlackJack";
                        }
                        //Check for split and if pot contains at least the amount originally bet
                        else if (Hand[CurrentHand].Cards[0].Rank == Hand[CurrentHand].Cards[1].Rank &&
                                 Pot.PotValue >= BetPot[CurrentHand].PotValue)
                        {
                            //Initial two cards have the same rank, so split is available
                            CanSplit = true;
                        }
                        if (!PlayerStatus[CurrentHand].Equals("BlackJack"))
                        {
                            //Check if the player can double down allowed on 10 and 11
                            for (int i = 0; i < Hand[CurrentHand].HandValue.Count; i++)
                            {
                                if ((Hand[CurrentHand].HandValue[i] == 10 || Hand[CurrentHand].HandValue[i] == 11) &&
                                     Pot.PotValue >= BetPot[CurrentHand].PotValue)
                                {
                                    doubleDownIndex = i;
                                    CanDoubleDown = true;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("A bet must be made first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Stay()
        {
            if (!PlayerStatus[CurrentHand].Equals("Bust") && 
                !PlayerStatus[CurrentHand].Equals("BlackJack") &&
                initialHandDealt &&
                Hand[CurrentHand].Cards.Count > 1)
            {
                isStay[CurrentHand] = true;
                PlayerStatus[CurrentHand] = "Stay";
                //Split Hand
                if (Hand.Count == 2 && CurrentHand == 0)
                {
                    CurrentHand++;
                }
                //Prevent splitting should the player decide to stay
                CanSplit = false;
            }
            
        }

        /// <summary>
        /// Get a card from the draw pile
        /// </summary>
        /// <param name="drawPile"></param>
        public void Hit(DrawPile drawPile)
        {
            if (initialHandDealt && !isStay[CurrentHand] &&
                !PlayerStatus[CurrentHand].Equals("BlackJack") && 
                !PlayerStatus[CurrentHand].Equals("Bust"))
            {
                drawPile.Deal(Hand[CurrentHand]);
                //Prevent any splitting if the split was not taken when the initial cards were dealt
                //The same for Double Down
                CanSplit = false;
                CanDoubleDown = false;

                if (isSplit &&
                    Hand[CurrentHand].Cards.Count == 2 &&
                    Hand[CurrentHand].HandValue.Max() == 21)
                {
                    //then blackjack
                    PlayerStatus[CurrentHand] = "BlackJack";
                    if (CurrentHand == 0)
                    {
                        CurrentHand++;
                    }
                }

                if (Hand[CurrentHand].HandValue.Count > 0 &&
                    Hand[CurrentHand].Cards.Count > 2 &&
                    Hand[CurrentHand].HandValue.Max() == 21)
                {
                    //then stay
                    this.Stay();
                }
                //Check if bust
                else if (Hand[CurrentHand].Status.Equals("Bust"))
                {
                    PlayerStatus[CurrentHand] = "Bust";
                    ////lose bet pot
                    //BetPot[CurrentHand].Clear();
                    if (Hand.Count == 2 && CurrentHand == 0)
                    {
                        CurrentHand++;
                    }
                }
            }
        }

        /// <summary>
        /// The  initially dealt two cards can be split if they are of the same rank
        /// </summary>
        public void Split()
        {
            if (!isSplit && CanSplit)
            {
                Hand.Add(new BlackJackHand(Name + "-2"));
                Hand[CurrentHand + 1].AddCard(Hand[CurrentHand].PopCardAtIndex(1));
                isSplit = true;
                CanSplit = false;
                //Add a player status for the new hand
                PlayerStatus.Add("Play");
                //Add to Bet pot and remove from Pot
                Pot.RemoveFromPot(BetPot[CurrentHand].PotValue);
                BetPot.Add(new PlayerPot(BetPot[CurrentHand].PotValue));
                isStay.Add(false);
                CanDoubleDown = false;
            }
        }

        /// <summary>
        /// Send the players hand/s to the discard pile
        /// and reset all parameters
        /// </summary>
        /// <param name="discardPile"></param>
        public void Discard(CardCollection discardPile)
        {
            //Send the players hand to the discard pile
            foreach (BlackJackHand hand in Hand)
            {
                hand.DiscardHand(discardPile);
            }
            //Reset current hand
            CurrentHand = 0;
            //Reset Player status
            PlayerStatus = new List<string>();
            PlayerStatus.Add("Waiting");
            //Reset Hand
            Hand = new List<BlackJackHand>();
            Hand.Add(new BlackJackHand(Name + "-1")); //first hand
            //Reset BetPot            
            BetPot = new List<PlayerPot>();
            BetPot.Add(new PlayerPot()); //Betting on the first hand
            //Set stay 
            isStay = new List<bool>();
            isStay.Add(false);
            //Set split
            CanSplit = false;
            isSplit = false;
            //Set initial hand has been dealt
            initialHandDealt = false;
            //Set DoubleDown
            CanDoubleDown = false;
        }

        public void DoubleDown(DrawPile drawPile)
        {
            if (CanDoubleDown)
            {
                //Double bet amount
                int amount = BetPot[CurrentHand].PotValue;
                BetPot[CurrentHand].AddToPot(amount);
                Pot.RemoveFromPot(amount);
                //Set Hand.DoubleDown to true
                Hand[CurrentHand].DoubleDown = true;
                //Deal one card to hand
                drawPile.Deal(Hand[CurrentHand]);
                //set player status to stay 
                PlayerStatus[CurrentHand] = "Stay";
                //Set CanDoubleDown to false
                CanDoubleDown = false;
                CanSplit = false;
            }
            
        }

        public override string ToString()
        {
            string playerStatus = $"{Name}:\r\n";
            playerStatus += $"Pot Amount: {Pot.PotValue}\r\n\r\n";
            
            for (int i = 0; i < Hand.Count; i++)
            {
                if ( BetPot.Count == 0)
                {
                    playerStatus += $"Bet Amount: 0\r\n" ;
                }
                else
                {
                    playerStatus += $"Bet Amount: {BetPot[i].PotValue}\r\n";
                }
                
                playerStatus += "Cards: " + Hand[i].ToString() + "\r\n";
                if (Hand[i].HandValue == null || Hand[i].HandValue.Count == 0)
                {
                    playerStatus += "Hand Value: " + "" + "\r\n";
                }
                else
                {
                    playerStatus += "Hand Value: " + String.Join(":", Hand[i].HandValue) + "\r\n";
                }
                if (isStay[CurrentHand] && !PlayerStatus[i].Equals("Bust"))
                {
                    playerStatus += $"Status: {PlayerStatus[i]}\r\n\r\n";
                }
                else
                {
                    playerStatus += $"Status: {PlayerStatus[i]}\r\n\r\n";
                }
            }
            return playerStatus;
        }


        //THE PLAYER CAN
        //Bet
        //Stay
        //Hit
        //Split
        //Double Down
        //Insurance - maybe
        //Discard hand/s

    }
}
