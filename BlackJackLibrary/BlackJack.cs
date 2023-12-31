﻿using CardsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BlackJackLibrary
{
    public class BlackJack
    {
        public Player[] Players { get; }
        public DrawPile DrawPile { get; }
        public CardCollection DiscardPile { get; }
        public int CurrentPlayer { get; private set; }
        public Dealer Dealer { get; }
        public string[,] PlayerWinLossState { get; private set; }
        public string DealerWinLossState { get; private set; }


        private const int MAX_PLAYERS = 4;
        private const int BUY_IN_AMOUNT = 1000;
        private const int NUMBER_OF_DECKS_IN_DRAWPILE = 6; //Initial number of decks in the drawpile
        private const int MAX_HANDS_PER_PLAYER = 2;

        private bool handDealt = false;
        private bool isDealersTurn = false;
        private bool roundComplete = false;

        public BlackJack()
        {
            this.Players = new Player[MAX_PLAYERS];
            this.DrawPile = new DrawPile("Draw Pile", NUMBER_OF_DECKS_IN_DRAWPILE);
            this.DiscardPile = new CardCollection("Discard Pile");
            this.Dealer = new Dealer("Dealer");
            InitializePlayerWinLossState();
        }

        public BlackJack(Image cardImage)
        {
            this.Players = new Player[MAX_PLAYERS];
            this.DrawPile = new DrawPile(cardImage, "Draw Pile", NUMBER_OF_DECKS_IN_DRAWPILE);
            this.DiscardPile = new CardCollection("Discard Pile");
            this.Dealer = new Dealer("Dealer");
            InitializePlayerWinLossState();
        }

        public void AddPlayer(int playerPosition)
        {
            this.Players[playerPosition] = new Player(playerPosition.ToString());
            this.Players[playerPosition].Pot.AddToPot(BUY_IN_AMOUNT);
        }

        public void RemovePlayer(int playerPosition)
        {
            this.Players[playerPosition] = null;
        }

        public void PlaceInitialBet(int playerIndex, int amount)
        {
            if (!handDealt && amount > 0)
            {
                this.Players[playerIndex].Bet(amount);
            }
        }

        public void Deal()
        {
            if (!handDealt)
            {
                this.Dealer.DealAll(this.DrawPile, this.Players);
                handDealt = true;
            }
        }

        public void SettleBets()
        {
            if (roundComplete)
            {
                string dealerStatus = GetDealerStatus();
                int dealerHandValue = 0;
                if (!dealerStatus.Equals("Bust"))
                {
                    dealerHandValue = this.Dealer.Hand.HandValue.Max();
                }

                switch (dealerStatus)
                {
                    case "BlackJack":
                        //Compare each players against the dealer
                        DealerWinLossState = "BlackJack";
                        for (int i = 0; i < MAX_PLAYERS; i++)
                        {
                            if (Players[i] != null && Players[i].BetPot.Count > 0)
                            {
                                for (int j = 0; j < Players[i].BetPot.Count; j++)
                                {
                                    if (Players[i].PlayerStatus[j].Equals("BlackJack"))
                                    {
                                        //get your bet back
                                        Players[i].Pot.AddToPot(Players[i].BetPot[j].PotValue);
                                        PlayerWinLossState[i, j] = "Push";
                                    }
                                    else
                                    {
                                        if (Players[i].BetPot[j].PotValue > 0)
                                        {
                                            PlayerWinLossState[i, j] = "Loses: " + Players[i].BetPot[j].PotValue.ToString();
                                        }
                                    }
                                }
                            }
                            if (Players[i] != null)
                            {
                                Players[i].BetPot.Clear();
                            }
                        }
                        break;
                    case "Bust":
                        //Any player not bust wins
                        DealerWinLossState = "Bust";
                        for (int i = 0; i < MAX_PLAYERS; i++)
                        {
                            if (Players[i] != null && Players[i].BetPot.Count > 0)
                            {
                                for (int j = 0; j < Players[i].PlayerStatus.Count; j++)
                                {
                                    string playerStatus = Players[i].PlayerStatus[j];
                                    switch (playerStatus)
                                    {
                                        case "BlackJack":
                                            //pays approximately 3:2
                                            Players[i].Pot.AddToPot((int)Math.Ceiling((double)(Players[i].BetPot[j].PotValue * 2.5)));
                                            PlayerWinLossState[i, j] = "Wins: " + ((int)Math.Ceiling((double)(Players[i].BetPot[j].PotValue * 1.5))).ToString();
                                            break;
                                        case "Stay":
                                            Players[i].Pot.AddToPot(Players[i].BetPot[j].PotValue * 2);
                                            PlayerWinLossState[i, j] = "Wins: " + Players[i].BetPot[j].PotValue.ToString();
                                            break;
                                        default:
                                            if (Players[i].BetPot[j].PotValue > 0)
                                            {
                                                PlayerWinLossState[i, j] = "Loses: " + Players[i].BetPot[j].PotValue.ToString();
                                            }
                                            break;
                                    }
                                }
                                if (Players[i] != null)
                                {
                                    Players[i].BetPot.Clear();
                                }
                            }
                        }
                        break;
                    case "Stay":
                        DealerWinLossState = Dealer.Hand.HandValue.Max().ToString();
                        for (int i = 0; i < MAX_PLAYERS; i++)
                        {
                            if (Players[i] != null && Players[i].BetPot.Count > 0)
                            {
                                for (int j = 0; j < Players[i].PlayerStatus.Count; j++)
                                {
                                    string playerStatus = Players[i].PlayerStatus[j];
                                    switch (playerStatus)
                                    {
                                        case "BlackJack":
                                            //pays approximately 3:2
                                            Players[i].Pot.AddToPot((int)Math.Ceiling((double)(Players[i].BetPot[j].PotValue * 2.5)));
                                            PlayerWinLossState[i, j] = "Wins: " + ((int)Math.Ceiling((double)(Players[i].BetPot[j].PotValue * 1.5))).ToString();
                                            break;
                                        case "Stay":
                                            if (Players[i].Hand[j].HandValue.Max() > dealerHandValue)
                                            {
                                                //Return double bet amount
                                                Players[i].Pot.AddToPot(Players[i].BetPot[j].PotValue * 2);
                                                PlayerWinLossState[i, j] = "Wins: " + Players[i].BetPot[j].PotValue.ToString();
                                            }
                                            else if (Players[i].Hand[j].HandValue.Max() == dealerHandValue)
                                            {
                                                //Return bet amount only
                                                Players[i].Pot.AddToPot(Players[i].BetPot[j].PotValue);
                                                PlayerWinLossState[i, j] = "Push";
                                            }
                                            else
                                            {
                                                if (Players[i].BetPot[j].PotValue > 0)
                                                {
                                                    PlayerWinLossState[i, j] = "Loses: " + Players[i].BetPot[j].PotValue.ToString();
                                                }
                                            }
                                            break;
                                        case "Bust":
                                            if (Players[i].BetPot[j].PotValue > 0)
                                            {
                                                PlayerWinLossState[i, j] = "Loses: " + Players[i].BetPot[j].PotValue.ToString();
                                            }
                                            break;

                                    }
                                }
                            }
                            if (Players[i] != null)
                            {
                                Players[i].BetPot.Clear();
                            }
                            
                        }
                        break;
                }
            }
        }

        public void InitializePlayerWinLossState()
        {
            PlayerWinLossState = new string[MAX_PLAYERS, MAX_HANDS_PER_PLAYER];
            for (int i = 0; i < MAX_PLAYERS; i++)
            {
                for (int j = 0; j < MAX_HANDS_PER_PLAYER; j++)
                {
                    PlayerWinLossState[i, j] = "";
                }
            }
        }

        public void ClearPlayerWinLossState()
        {
            for (int i = 0; i < MAX_PLAYERS; i++)
            {
                for (int j = 0; j < MAX_HANDS_PER_PLAYER; j++)
                {
                    PlayerWinLossState[i, j] = "";
                }
            }
        }

        /// <summary>
        /// Check if any player has blackjack
        /// </summary>
        /// <returns></returns>
        private bool APlayerHasBlackJack()
        {
            for (int i = 0; i < MAX_PLAYERS; i++)
            {
                for (int j = 0; j < Players[i].PlayerStatus.Count; j++)
                {
                    if (Players[i].PlayerStatus[j].Equals("BlackJack"))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool APlayerHasStay()
        {
            for (int i = 0; i < MAX_PLAYERS; i++)
            {
                if (Players[i] != null && Players[i].BetPot[0].PotValue > 0)
                {
                    foreach (string status in Players[i].PlayerStatus)
                    {
                        if (status == "Stay")
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool IsDealersTurn()
        {
            GetCurrentPlayer();
            if (CurrentPlayer == -1 && handDealt && !roundComplete)
            {
                return true;
            }
            return false;
        }

        public void DealersTurn()
        {
            if (APlayerHasStay())
            {
                this.Dealer.Play(this.DrawPile);
                roundComplete = true;
            }
            else
            {
                this.Dealer.Stay();
                this.Dealer.Play(this.DrawPile);
                roundComplete = true;
            }
        }

        public void Discard()
        {
            this.Dealer.Discard(this.DiscardPile, this.Players);
            handDealt = false;
            roundComplete = false;
        }

        public void Hit()
        {
            GetCurrentPlayer();
            this.Dealer.HitPlayer(this.DrawPile, Players[CurrentPlayer]);
        }

        public void Stay()
        {
            GetCurrentPlayer();
            Players[CurrentPlayer].Stay();
        }

        public void Split()
        {
            GetCurrentPlayer();
            Players[CurrentPlayer].Split();
        }

        public void DoubleDown()
        {
            GetCurrentPlayer();
            Players[CurrentPlayer].DoubleDown(this.DrawPile);
        }

        public void GetCurrentPlayer()
        {
            for (int i = 0; i < this.Players.Length; i++)
            {
                if (this.Players[i] != null && this.Players[i].PlayerStatus[this.Players[i].CurrentHand].Equals("Play"))
                {
                    CurrentPlayer = i;
                    return;
                }
            }
            CurrentPlayer = -1; //All players played
        }

        public bool CurrentPlayerCanHit()
        {
            GetCurrentPlayer();
            
            if (CurrentPlayer != -1 && handDealt)
            {
                int currentHand = Players[CurrentPlayer].CurrentHand;
                return Players[CurrentPlayer].PlayerStatus[currentHand].Equals("Play");
            }
            return false;
        }

        public bool CurrentPlayerCanStay()
        {
            GetCurrentPlayer();
            
            if (CurrentPlayer != -1 && handDealt)
            {
                int currentHand = Players[CurrentPlayer].CurrentHand;
                return Players[CurrentPlayer].PlayerStatus[currentHand].Equals("Play");
            }
            return false;
        }

        public bool CurrentPlayerCanSplit()
        {
            GetCurrentPlayer();
            if (CurrentPlayer != -1)
            {
                return Players[CurrentPlayer].CanSplit;
            }
            return false;
        }

        public bool CurrentPlayerCanDoubleDown()
        {
            GetCurrentPlayer();
            if (CurrentPlayer != -1)
            {
                return Players[CurrentPlayer].CanDoubleDown;
            }
            return false;
        }

        public List<string> GetPlayerStatus(int playerIndex)
        {
            return Players[playerIndex].PlayerStatus;
        }

        public string GetPlayerToString(int playerIndex)
        {
            if (Players[playerIndex] != null)
            {
                return Players[playerIndex].ToString();
            }
            return "";
        }

        public string GetDealerStatus()
        {
            return this.Dealer.Status;
        }

        public override string ToString()
        {
            string gameStatus = this.Dealer.ToString() + "\r\n\r\n";
            for (int i = 0; i < MAX_PLAYERS; i++)
            {
                if (this.Players[i] != null)
                {
                    gameStatus += this.Players[i].ToString() + "\r\n\r\n";
                }
            }
            return gameStatus;
        }

        public void CombineDiscardWithDrawPile()
        {
            DiscardPile.DealAll(DrawPile);
        }
    }
}
