using BlackJackLibrary;
using CardsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualCardsLibray;

namespace GamesWinFormsUI
{
    public partial class FrmBlackJack : Form
    {
        public FrmBlackJack()
        {
            InitializeComponent();
        }

        private BlackJack game;
        private VisualBlackJackHand[] vBJHand;
        private VisualBlackJackHand vDealer;
        private const int NUM_PLAYERS = 4;
        private const int CARD_WIDTH = 85;
        private const int CARD_HEIGHT = 115;
        private Image CARD_BACK = Properties.Resources.cardBack;
        private bool isDrawn = false;
        private List<VisualCard> moveCards;
        private int deltaX; //Used for moving cards
        private int deltaY; //Used for moving cards
        private int numMoves; // Used for moving cards
        private int numCardsToMove; //Used for moving cards
        private VisualCard moveVCard; //Used for moving cards
        private Random random = new Random(); //Used for moving cards
        private bool isDoubleDown; //Checks if hit or double down selected
        private TextBox[,] PlayerHandStates = new TextBox[4, 2]; //Max of four players. Max of two hands per player
        private TextBox[,] PlayerBets = new TextBox[4, 2]; //Max of four players. Max of two hands per player
        private int minDrawPileCount;
        private bool playSound = true;
        private SoundPlayer dealCardSound;

        private void FrmBlackJack_Load(object sender, EventArgs e)
        {
            PicPlayerPosition0.SendToBack();
            PicPlayerPosition1.SendToBack();
            PicPlayerPosition2.SendToBack();
            PicPlayerPosition3.SendToBack();

            Image image = Properties.Resources.Cards;
            game = new BlackJack(image);
            game.DrawPile.Shuffle();
            game.DrawPile.Shuffle();
            minDrawPileCount = (int)((double)game.DrawPile.Cards.Count * 0.2);

            NewVHand();
            moveCards = new List<VisualCard>();

            LoadSounds();


            ShowCurrentPlayer();
            BetButtonVisibility();
            BtnDeal.Visible = false;
            BtnDiscard.Visible = false;

            AddPlayerStatesTextBox();
            AddPlayerBetsTextBox();
            SetDealerHandState();
            ShowPotValue();
            SetPlayButtonVisibility();

            ShowCurrentPlayer();
        }

        private void LoadSounds()
        {
            try
            {
                dealCardSound = new SoundPlayer(Properties.Resources.Dealcard);
            }
            catch (Exception)
            {
                playSound = false;
            }
        }

        private void PlayDealingCardSound()
        {
            if (playSound)
            {
                dealCardSound.Play();
            }
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            Card card = new Card(CardEnums.Suits.Clubs, CardEnums.Ranks.Ace);
            card.Value = 1;
            game.DrawPile.AddCard(card);
            game.DrawPile.AddCard(card);

            card = new Card(CardEnums.Suits.Clubs, CardEnums.Ranks.Ten);
            card.Value = 10;
            game.DrawPile.AddCard(card);
            game.DrawPile.AddCard(card);
        }


        private void BtnJoinGame_Clicked(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "BtnJoin0":
                    game.AddPlayer(0);
                    BtnJoin0.Visible = false;
                    break;
                case "BtnJoin1":
                    game.AddPlayer(1);
                    BtnJoin1.Visible = false;
                    break;
                case "BtnJoin2":
                    game.AddPlayer(2);
                    BtnJoin2.Visible = false;
                    break;
                case "BtnJoin3":
                    game.AddPlayer(3);
                    BtnJoin3.Visible = false;
                    break;
            }
            BetButtonVisibility();
            ShowPotValue();
        }

        private void ShowJoinButton()
        {
            for (int i = 0; i < NUM_PLAYERS; i++)
            {
                if (game.Players[i] == null)
                {
                    switch (i)
                    {
                        case 0:
                            BtnJoin0.Visible = true;
                            break;
                        case 1:
                            BtnJoin1.Visible = true;
                            break;
                        case 2:
                            BtnJoin2.Visible = true;
                            break;
                        case 3:
                            BtnJoin3.Visible = true;
                            break;
                    }
                }
            }
        }

        private void HideJoinButton()
        {
            for (int i = 0; i < NUM_PLAYERS; i++)
            {
                switch (i)
                {
                    case 0:
                        BtnJoin0.Visible = false;
                        break;
                    case 1:
                        BtnJoin1.Visible = false;
                        break;
                    case 2:
                        BtnJoin2.Visible = false;
                        break;
                    case 3:
                        BtnJoin3.Visible = false;
                        break;
                }
            }
        }
        private void BtnConfirmBet_Clicked(object sender, EventArgs e)
        {
            Button bet = (Button)sender;

            switch (bet.Name)
            {
                case "BtnConfirmBet0":
                    if (game.Players[0] != null && TxtBetAmount0.Text != "0")
                    {
                        if (game.Players[0].Pot.PotValue < Convert.ToInt32(TxtBetAmount0.Text))
                        {
                            game.PlaceInitialBet(0, game.Players[0].Pot.PotValue);
                            PnlPlayer0.Visible = false;
                        }
                        else
                        {
                            game.PlaceInitialBet(0, Convert.ToInt32(TxtBetAmount0.Text));
                            PnlPlayer0.Visible = false;
                        }

                    }

                    break;
                case "BtnConfirmBet1":
                    if (game.Players[1] != null && TxtBetAmount1.Text != "0")
                    {
                        if (game.Players[1].Pot.PotValue < Convert.ToInt32(TxtBetAmount1.Text))
                        {
                            game.PlaceInitialBet(1, game.Players[1].Pot.PotValue);
                            PnlPlayer1.Visible = false;
                        }
                        else
                        {
                            game.PlaceInitialBet(1, Convert.ToInt32(TxtBetAmount1.Text));
                            PnlPlayer1.Visible = false;
                        }
                    }

                    break;
                case "BtnConfirmBet2":
                    if (game.Players[2] != null && TxtBetAmount2.Text != "0")
                    {
                        if (game.Players[2].Pot.PotValue < Convert.ToInt32(TxtBetAmount2.Text))
                        {
                            game.PlaceInitialBet(2, game.Players[2].Pot.PotValue);
                            PnlPlayer2.Visible = false;
                        }
                        else
                        {
                            game.PlaceInitialBet(2, Convert.ToInt32(TxtBetAmount2.Text));
                            PnlPlayer2.Visible = false;
                        };
                    }

                    break;
                case "BtnConfirmBet3":
                    if (game.Players[3] != null && TxtBetAmount3.Text != "0")
                    {
                        if (game.Players[3].Pot.PotValue < Convert.ToInt32(TxtBetAmount3.Text))
                        {
                            game.PlaceInitialBet(3, game.Players[3].Pot.PotValue);
                            PnlPlayer3.Visible = false;
                        }
                        else
                        {
                            game.PlaceInitialBet(3, Convert.ToInt32(TxtBetAmount3.Text));
                            PnlPlayer3.Visible = false;
                        }
                    }

                    break;
            }
            isDrawn = false;

            if (BetWasPlaced())
            {
                BtnDeal.Visible = true;
            }
            SetPlayerStatesVisibility();
            SetPlayerBetsVisibility();
            SetDealerHandState();
            ShowPotValue();
            SetPlayButtonVisibility();
        }

        private void BtnDeal_Click(object sender, EventArgs e)
        {
            PlayDealingCardSound();
            HideJoinButton();
            BtnDeal.Visible = false;
            if (BetWasPlaced())
            {
                VDeal();
            }
        }

        private void VDeal()
        {
            //Collect the image cards from the DrawPile
            //for the dealer and each player that has 
            //placed a bet
            //Two cards per player
            int index = game.DrawPile.Cards.Count;
            for (int i = 0; i < 2; i++)
            {
                //Dealer
                int y = PicDrawPile.Top;
                int x = PicDrawPile.Left;
                index--;
                Card card = game.DrawPile.GetCardAtIndex(index);
                VisualCard vCard = new VisualCard(CARD_WIDTH, CARD_HEIGHT, x, y, card.CardImage, CARD_BACK);
                vCard.HomeX = this.ClientSize.Width / 2 - CARD_WIDTH / 2;
                vCard.HomeY = 10 + 40 * i;
                vCard.DealTo = i.ToString(); // used to show the back of the dealers second card
                vDealer.Hand[0].Add(vCard);
                moveCards.Add(vCard);

                //Players
                for (int j = 0; j < NUM_PLAYERS; j++)
                {
                    if (game.Players[j] != null && game.Players[j].BetPot[0].PotValue > 0)
                    {
                        switch (j)
                        {
                            case 0:
                                index--;
                                card = game.DrawPile.GetCardAtIndex(index);
                                vCard = new VisualCard(CARD_WIDTH, CARD_HEIGHT, x, y, card.CardImage, CARD_BACK);
                                //Set Destination
                                vCard.HomeY = PnlPlayer0.Top + 20 + 40 * i;
                                vCard.HomeX = PnlPlayer0.Left + 10;
                                vBJHand[j].Hand[0].Add(vCard);
                                moveCards.Add(vCard);
                                break;
                            case 1:
                                index--;
                                card = game.DrawPile.GetCardAtIndex(index);
                                vCard = new VisualCard(CARD_WIDTH, CARD_HEIGHT, x, y, card.CardImage, CARD_BACK);
                                //Set Destination
                                vCard.HomeY = PnlPlayer1.Top + 20 + 40 * i;
                                vCard.HomeX = PnlPlayer1.Left + 10;
                                vBJHand[j].Hand[0].Add(vCard);
                                moveCards.Add(vCard);
                                break;
                            case 2:
                                index--;
                                card = game.DrawPile.GetCardAtIndex(index);
                                vCard = new VisualCard(CARD_WIDTH, CARD_HEIGHT, x, y, card.CardImage, CARD_BACK);
                                //Set Destination
                                vCard.HomeY = PnlPlayer2.Top + 20 + 40 * i;
                                vCard.HomeX = PnlPlayer2.Left + 10;
                                vBJHand[j].Hand[0].Add(vCard);
                                moveCards.Add(vCard);
                                break;
                            case 3:
                                index--;
                                card = game.DrawPile.GetCardAtIndex(index);
                                vCard = new VisualCard(CARD_WIDTH, CARD_HEIGHT, x, y, card.CardImage, CARD_BACK);
                                //Set Destination
                                vCard.HomeY = PnlPlayer3.Top + 20 + 40 * i;
                                vCard.HomeX = PnlPlayer3.Left + 10;
                                vBJHand[j].Hand[0].Add(vCard);
                                moveCards.Add(vCard);
                                break;
                        }
                    }
                }
            }


            for (int i = 0; i < vDealer.Hand.Count; i++)
            {
                for (int j = 0; j < vDealer.Hand[i].Count; j++)
                {
                    VisualCard vsCard = vDealer.Hand[i][j];
                    vsCard.ShowBackImage();
                    this.Controls.Add(vsCard);
                    vsCard.BringToFront();
                }
            }

            for (int k = 0; k < NUM_PLAYERS; k++)
            {
                if (game.Players[k] != null && game.Players[k].BetPot.Count > 0)
                {
                    for (int l = 0; l < vBJHand[k].Hand.Count; l++)
                    {
                        foreach (VisualCard vsCard in vBJHand[k].Hand[l])
                        {
                            vsCard.ShowBackImage();
                            this.Controls.Add(vsCard);
                            vsCard.BringToFront();
                        }
                    }
                }
            }
            MoveDealCards();
        }

        private void ShowCurrentPlayer()
        {
            game.GetCurrentPlayer();
            int currentPlayer = game.CurrentPlayer;
            switch (currentPlayer)
            {
                case 0:
                    LblPlayer0.Visible = true;
                    LblPlayer1.Visible = false;
                    LblPlayer2.Visible = false;
                    LblPlayer3.Visible = false;
                    break;
                case 1:
                    LblPlayer0.Visible = false;
                    LblPlayer1.Visible = true;
                    LblPlayer2.Visible = false;
                    LblPlayer3.Visible = false;
                    break;
                case 2:
                    LblPlayer0.Visible = false;
                    LblPlayer1.Visible = false;
                    LblPlayer2.Visible = true;
                    LblPlayer3.Visible = false;
                    break;
                case 3:
                    LblPlayer0.Visible = false;
                    LblPlayer1.Visible = false;
                    LblPlayer2.Visible = false;
                    LblPlayer3.Visible = true;
                    break;
                case -1:
                    LblPlayer0.Visible = false;
                    LblPlayer1.Visible = false;
                    LblPlayer2.Visible = false;
                    LblPlayer3.Visible = false;
                    break;
            }
        }

        private void BtnHit_Click(object sender, EventArgs e)
        {
            PlayDealingCardSound();
            HidePlayButtons();
            isDoubleDown = false;
            VHit();
        }

        private void VHit()
        {
            int index = game.DrawPile.Cards.Count - 1;
            //Get the current player and their current hand
            game.GetCurrentPlayer();
            int currentPlayer = game.CurrentPlayer;
            int currentHand = game.Players[currentPlayer].CurrentHand;
            //Set current position in Drawpile
            int y = PicDrawPile.Top;
            int x = PicDrawPile.Left;
            Card card = game.DrawPile.GetCardAtIndex(index);
            VisualCard vCard = new VisualCard(CARD_WIDTH, CARD_HEIGHT, x, y, card.CardImage, CARD_BACK);
            //Set Destination
            int lastCardIndex = vBJHand[currentPlayer].Hand[currentHand].Count - 1;
            vCard.HomeY = vBJHand[currentPlayer].Hand[currentHand][lastCardIndex].Top + 40;
            vCard.HomeX = vBJHand[currentPlayer].Hand[currentHand][lastCardIndex].Left;
            //Set image and add it to the players current hand
            vCard.ShowBackImage();
            vBJHand[currentPlayer].Hand[currentHand].Add(vCard);
            //Add to the form
            this.Controls.Add(vCard);
            vCard.BringToFront();
            //move the card
            moveCards.Add(vCard);
            MoveHitCard();
        }

        private void BtnStay_Click(object sender, EventArgs e)
        {
            HidePlayButtons();
            game.Stay();
            SetPlayButtonVisibility();
            ShowCurrentPlayer();
            //check if all players are complete
            //if yes then dealers turn
            if (game.IsDealersTurn())
            {
                SetPlayerStatesVisibility();
                game.DealersTurn();
                VDealersTurn();
            }
            else
            {
                SetPlayerStatesVisibility();
            }
        }

        private void BtnSplit_Click(object sender, EventArgs e)
        {
            PlayDealingCardSound();
            HidePlayButtons();
            VSplit();
            game.Split();
            SetPlayButtonVisibility();
            ShowCurrentPlayer();
            SetPlayerStatesVisibility();
            SetPlayerBetsVisibility();
            ShowPotValue();

        }

        private void VSplit()
        {
            //get the current player and their hand
            game.GetCurrentPlayer();
            int currentPlayer = game.CurrentPlayer;
            int currentHand = game.Players[currentPlayer].CurrentHand;
            int lastVCardIndex = game.Players[currentPlayer].Hand[currentHand].Cards.Count - 1;
            VisualCard vCard = vBJHand[currentPlayer].Hand[currentHand][lastVCardIndex];
            vBJHand[currentPlayer].AddNewHand();
            vBJHand[currentPlayer].Hand[currentHand + 1].Add(vCard);
            vBJHand[currentPlayer].Hand[currentHand].RemoveAt(lastVCardIndex);
            //Set the cards discard position
            vCard.HomeX = PicDiscardPile.Left;
            vCard.HomeY = PicDiscardPile.Top;
            vCard.Left += (CARD_WIDTH + 10);
            //Use the top of the first card in the players first hand
            vCard.Top = vBJHand[currentPlayer].Hand[currentHand][0].Top;
            dealCardSound.Stop();
        }

        private void BtnDoubleDown_Click(object sender, EventArgs e)
        {
            HidePlayButtons();
            ShowPotValue();
            isDoubleDown = true;
            VHit();
        }

        private void BtnDiscard_Click(object sender, EventArgs e)
        {
            BtnDiscard.Visible = false;
            PlayDealingCardSound();
            ClearPlayerStates();
            ClearPlayerBets();
            ClearDealerState();
            VDiscard();
        }

        private void NudBetAmount0_ValueChanged(object sender, EventArgs e)
        {
            int betAmount = 100 * (int)NudHundreds0.Value + 10 * (int)NudTens0.Value + 1 * (int)NudOnes0.Value;
            if (betAmount > game.Players[0].Pot.PotValue)
            {
                betAmount = game.Players[0].Pot.PotValue;
            }
            TxtBetAmount0.Text = betAmount.ToString();
        }

        private void NudBetAmount1_ValueChanged(object sender, EventArgs e)
        {
            int betAmount = 100 * (int)NudHundreds1.Value + 10 * (int)NudTens1.Value + 1 * (int)NudOnes1.Value;
            if (betAmount > game.Players[1].Pot.PotValue)
            {
                betAmount = game.Players[1].Pot.PotValue;
            }
            TxtBetAmount1.Text = betAmount.ToString();
        }

        private void NudBetAmount2_ValueChanged(object sender, EventArgs e)
        {
            int betAmount = 100 * (int)NudHundreds2.Value + 10 * (int)NudTens2.Value + 1 * (int)NudOnes2.Value;
            if (betAmount > game.Players[2].Pot.PotValue)
            {
                betAmount = game.Players[2].Pot.PotValue;
            }
            TxtBetAmount2.Text = betAmount.ToString();
        }

        private void NudBetAmount3_ValueChanged(object sender, EventArgs e)
        {
            int betAmount = 100 * (int)NudHundreds3.Value + 10 * (int)NudTens3.Value + 1 * (int)NudOnes3.Value;
            if (betAmount > game.Players[3].Pot.PotValue)
            {
                betAmount = game.Players[3].Pot.PotValue;
            }
            TxtBetAmount3.Text = betAmount.ToString();
        }

        private bool BetWasPlaced()
        {
            foreach (Player player in game.Players)
            {
                if (player != null && player.BetPot[player.CurrentHand].PotValue > 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void HidePlayButtons()
        {
            BtnHit.Visible = false;
            BtnStay.Visible = false;
            BtnSplit.Visible = false;
            BtnDoubleDown.Visible = false;
        }

        private void SetPlayButtonVisibility()
        {
            if (game.CurrentPlayerCanHit())
            {
                BtnHit.Visible = true;
            }
            else
            {
                BtnHit.Visible = false;
            }

            if (game.CurrentPlayerCanStay())
            {
                BtnStay.Visible = true;
            }
            else
            {
                BtnStay.Visible = false;
            }

            if (game.CurrentPlayerCanSplit())
            {
                BtnSplit.Visible = true;
            }
            else
            {
                BtnSplit.Visible = false;
            }

            if (game.CurrentPlayerCanDoubleDown())
            {
                BtnDoubleDown.Visible = true;
            }
            else
            {
                BtnDoubleDown.Visible = false;
            }
        }

        private void BetButtonVisibility()
        {

            if (game.Players[0] == null || game.Players[0].BetPot[0].PotValue > 0)
            {
                PnlPlayer0.Visible = false;
            }
            else
            {
                PnlPlayer0.Visible = true;
            }

            if (game.Players[1] == null || game.Players[1].BetPot[0].PotValue > 0)
            {
                PnlPlayer1.Visible = false;
            }
            else
            {
                PnlPlayer1.Visible = true;
            }

            if (game.Players[2] == null || game.Players[2].BetPot[0].PotValue > 0)
            {
                PnlPlayer2.Visible = false;
            }
            else
            {
                PnlPlayer2.Visible = true;
            }

            if (game.Players[3] == null || game.Players[3].BetPot[0].PotValue > 0)
            {
                PnlPlayer3.Visible = false;
            }
            else
            {
                PnlPlayer3.Visible = true;
            }
        }

        private void DisableBetButtons()
        {
            BtnConfirmBet0.Enabled = false;
            BtnConfirmBet1.Enabled = false;
            BtnConfirmBet2.Enabled = false;
            BtnConfirmBet3.Enabled = false;
        }

        private void EnableBetButtons()
        {
            BtnConfirmBet0.Enabled = true;
            BtnConfirmBet1.Enabled = true;
            BtnConfirmBet2.Enabled = true;
            BtnConfirmBet3.Enabled = true;
        }

        private void ShowBetGroups()
        {
            for (int i = 0; i < game.Players.Length; i++)
            {
                if (game.Players[i] != null)
                {
                    string grpName = "GrpPotBet" + i.ToString();
                    switch (i)
                    {
                        case 0:
                            PnlPlayer0.Visible = true;
                            break;
                        case 1:
                            PnlPlayer1.Visible = true;
                            break;
                        case 2:
                            PnlPlayer2.Visible = true;
                            break;
                        case 3:
                            PnlPlayer3.Visible = true;
                            break;
                    }

                }
            }
        }

        private void FrmBlackJack_Paint(object sender, PaintEventArgs e)
        {

        }



        private void FrmBlackJack_Resize(object sender, EventArgs e)
        {
            isDrawn = false;
            FrmBlackJack_Paint(null, null);
        }

        private void CalcDeltaXY(VisualCard vCard, int numPixelsToMovePerStep = 35)
        {
            numMoves = Math.Max(Math.Abs(vCard.HomeY - vCard.Top), Math.Abs(vCard.HomeX - vCard.Left)) / numPixelsToMovePerStep;
            deltaX = (vCard.HomeX - vCard.Left) / numMoves;
            deltaY = (vCard.HomeY - vCard.Top) / numMoves;
        }

        private void VDiscard()
        {
            //run through the dealers cards
            foreach (VisualCard vCard in vDealer.Hand[0])
            {
                moveCards.Add(vCard);
            }
            //run through all the players cards
            //and add to moveCards
            for (int i = 0; i < vBJHand.Length; i++)
            {
                //if (vBJHand[i].Hand != null && vBJHand[i].Hand.Count > 0)
                //{
                for (int j = 0; j < vBJHand[i].Hand.Count; j++)
                {
                    for (int k = 0; k < vBJHand[i].Hand[j].Count; k++)
                    {
                        moveCards.Add(vBJHand[i].Hand[j][k]);
                    }
                }
            }
            MoveDiscardCards();
        }

        private void VDealersTurn()
        {
            //Dealer currently has at least two cards in his visual hand
            //firs showing the face and second the back of the card
            //show the face of the back facing card
            //and check if he has any more in his code hand
            //if yes then deal these to him
            vDealer.Hand[0][1].ShowFrontImage();


            //Check if more than two cards in his hand
            if (game.Dealer.Hand.Cards.Count > 2)
            {
                for (int i = 2; i < game.Dealer.Hand.Cards.Count; i++)
                {
                    Image cardImage = game.Dealer.Hand.Cards[i].CardImage;
                    VisualCard vCard = new VisualCard(CARD_WIDTH, CARD_HEIGHT, PicDrawPile.Left, PicDrawPile.Top, cardImage, CARD_BACK);
                    //Get origin
                    int x = vDealer.Hand[0][0].Left;
                    int y = vDealer.Hand[0][0].Top + 40 * i;
                    //Set the destination
                    vCard.HomeX = x;
                    vCard.HomeY = y;
                    vCard.ShowBackImage();
                    //Add to vDealer
                    vDealer.Hand[0].Add(vCard);
                    //Add to MoveVCards
                    moveCards.Add(vCard);
                    this.Controls.Add(vCard);
                    vCard.BringToFront();
                }
                MoveDealersTurn();
            }
            else
            {

                BtnDiscard.Visible = true;
                game.SettleBets();
                SetPlayerWinLossState();
                SetDealerHandState();
                ShowPotValue();
            }

        }

        private void MoveDealersTurn()
        {
            numCardsToMove = moveCards.Count;
            TimMoveDealerTurnCards.Enabled = true;
        }

        private void MoveDiscardCards()
        {
            numCardsToMove = moveCards.Count;
            TimMoveDiscardCards.Enabled = true;

        }

        private void MoveDealCards()
        {
            numCardsToMove = moveCards.Count;
            TimMoveDealCards.Enabled = true;
        }

        private void MoveHitCard()
        {
            numCardsToMove = moveCards.Count;
            TimMoveHitCards.Enabled = true;
        }

        private void TimMoveDealCards_Tick(object sender, EventArgs e)
        {
            PlayDealingCardSound();
            moveVCard = moveCards[0];
            moveCards.RemoveAt(0);
            CalcDeltaXY(moveVCard);
            numCardsToMove--;
            TimMoveDealCards.Enabled = false;
            TimMoveDealCard.Enabled = true;
        }

        private void TimMoveDealCard_Tick(object sender, EventArgs e)
        {
            if (numMoves > 0)
            {
                moveVCard.MoveCard(deltaX, deltaY);
                numMoves--;
            }
            else
            {
                moveVCard.Left = moveVCard.HomeX + random.Next(-5, 6);
                moveVCard.Top = moveVCard.HomeY + random.Next(-5, 6);
                //if this is the dealers second card then show the back
                if (moveVCard.DealTo != null && moveVCard.DealTo.Equals("1"))
                {
                    moveVCard.ShowBackImage();
                }
                else
                {
                    moveVCard.ShowFrontImage();
                }

                moveVCard.HomeX = PicDiscardPile.Left;
                moveVCard.HomeY = PicDiscardPile.Top;

                TimMoveDealCard.Enabled = false;
                isDrawn = false;
                if (numCardsToMove > 0)
                {
                    TimMoveDealCards.Enabled = true;
                }
                else
                {
                    game.Deal();
                    BtnDeal.Visible = false;

                    DisableBetButtons();
                    //check if all players are complete may all have blackjack
                    //if yes then dealers turn
                    if (game.IsDealersTurn())
                    {
                        SetPlayerStatesVisibility();
                        ShowCurrentPlayer();
                        game.DealersTurn();
                        VDealersTurn();
                        dealCardSound.Stop();
                    }
                    else
                    {
                        ShowCurrentPlayer();
                        SetPlayerStatesVisibility();
                        dealCardSound.Stop();
                    }
                    SetPlayButtonVisibility();

                }

            }
        }

        private void TimMoveHitCards_Tick(object sender, EventArgs e)
        {
            PlayDealingCardSound();
            moveVCard = moveCards[0];
            moveCards.RemoveAt(0);
            CalcDeltaXY(moveVCard);
            numCardsToMove--;
            TimMoveHitCards.Enabled = false;
            TimMoveHitCard.Enabled = true;
        }

        private void TimMoveHitCard_Tick(object sender, EventArgs e)
        {
            if (numMoves > 0)
            {
                moveVCard.MoveCard(deltaX, deltaY);
                numMoves--;
            }
            else
            {


                moveVCard.Left = moveVCard.HomeX + random.Next(-5, 6);
                moveVCard.Top = moveVCard.HomeY + random.Next(-5, 6);
                moveVCard.HomeX = PicDiscardPile.Left;
                moveVCard.HomeY = PicDiscardPile.Top;
                moveVCard.ShowFrontImage();
                TimMoveHitCard.Enabled = false;
                isDrawn = false;
                FrmBlackJack_Paint(null, null);
                if (numCardsToMove > 0)
                {
                    TimMoveHitCards.Enabled = true;
                }
                else
                {
                    if (isDoubleDown)
                    {
                        game.DoubleDown();
                    }
                    else
                    {
                        game.Hit();
                    }


                    //check if all players are complete
                    //if yes then dealers turn
                    if (game.IsDealersTurn())
                    {
                        SetPlayerStatesVisibility();
                        ShowCurrentPlayer();
                        game.DealersTurn();
                        VDealersTurn();

                        dealCardSound.Stop();
                    }
                    else
                    {
                        ShowCurrentPlayer();
                        SetPlayerStatesVisibility();

                        dealCardSound.Stop();
                    }
                    SetPlayButtonVisibility();
                }

            }
        }

        private void TimMoveDiscardCards_Tick(object sender, EventArgs e)
        {
            PlayDealingCardSound();
            moveVCard = moveCards[moveCards.Count - 1];
            moveVCard.ShowBackImage();
            moveVCard.BringToFront();
            moveCards.RemoveAt(moveCards.Count - 1);
            CalcDeltaXY(moveVCard);
            numCardsToMove--;
            TimMoveDiscardCards.Enabled = false;
            timMoveDiscardCard.Enabled = true;
        }

        private void timMoveDiscardCard_Tick(object sender, EventArgs e)
        {
            if (numMoves > 0)
            {
                moveVCard.MoveCard(deltaX, deltaY);
                numMoves--;
            }
            else
            {
                if (PicDiscardPile.Image == null)
                {
                    PicDiscardPile.Image = Properties.Resources.cardBack;
                }
                timMoveDiscardCard.Enabled = false;
                if (this.Controls.Contains(moveVCard))
                {
                    this.Controls.Remove(moveVCard);
                    moveVCard.Dispose();
                }
                isDrawn = false;
                if (numCardsToMove > 0)
                {
                    TimMoveDiscardCards.Enabled = true;
                }
                else
                {
                    //clear all visual hands
                    game.Discard();
                    CheckDrawPileCount();
                    SetPlayButtonVisibility();
                    NewVHand();
                    ShowCurrentPlayer();
                    game.ClearPlayerWinLossState();
                    CheckPlayersPotValues();
                    ShowBetGroups();
                    EnableBetButtons();
                    ShowJoinButton();
                }
                dealCardSound.Stop();
            }
        }

        private void NewVHand()
        {
            vBJHand = new VisualBlackJackHand[NUM_PLAYERS];
            vBJHand[0] = new VisualBlackJackHand("0");
            vBJHand[1] = new VisualBlackJackHand("1");
            vBJHand[2] = new VisualBlackJackHand("2");
            vBJHand[3] = new VisualBlackJackHand("3");
            vDealer = new VisualBlackJackHand("Dealer");
        }

        private void TimMoveDealerTurnCards_Tick(object sender, EventArgs e)
        {
            PlayDealingCardSound();
            moveVCard = moveCards[0];
            moveVCard.ShowBackImage();
            moveCards.RemoveAt(0);
            CalcDeltaXY(moveVCard);
            numCardsToMove--;
            TimMoveDealerTurnCards.Enabled = false;
            TimMoveDealerTurnCard.Enabled = true;
        }

        private void TimMoveDealerTurnCard_Tick(object sender, EventArgs e)
        {
            if (numMoves > 0)
            {
                moveVCard.MoveCard(deltaX, deltaY);
                numMoves--;
            }
            else
            {
                moveVCard.ShowFrontImage();
                moveVCard.HomeX = PicDiscardPile.Left;
                moveVCard.HomeY = PicDiscardPile.Top;
                TimMoveDealerTurnCard.Enabled = false;
                isDrawn = false;
                SetDealerHandState();
                if (numCardsToMove > 0)
                {
                    TimMoveDealerTurnCards.Enabled = true;
                }
                else
                {
                    //clear all visual hands
                    game.SettleBets();
                    SetPlayerWinLossState();
                    SetDealerHandState();
                    ShowPotValue();
                    BtnDiscard.Visible = true;
                }
                dealCardSound.Stop();
            }
        }

        private void AddPlayerStatesTextBox()
        {
            int txtBoxOffset = -10;
            Font font = new Font("Segoe UI", 12, FontStyle.Bold);
            for (int i = 0; i < PlayerHandStates.GetLength(0); i++)
            {
                for (int j = 0; j < PlayerHandStates.GetLength(1); j++)
                {
                    TextBox txtBox = new TextBox();
                    txtBox.Font = font;
                    txtBox.BackColor = Color.Black;
                    txtBox.ForeColor = Color.White;
                    txtBox.Width = 100;
                    txtBox.Height = 29;
                    txtBox.TextAlign = HorizontalAlignment.Center;
                    txtBox.ReadOnly = true;
                    txtBox.TabStop = false;
                    txtBox.Name = i.ToString() + j.ToString();
                    //Position each text box
                    int left = 0;
                    int top = 0;
                    int width = 0;

                    switch (i)
                    {
                        case 0:
                            left = PnlPlayer0.Left;
                            top = PnlPlayer0.Top;
                            width = PnlPlayer0.Width;
                            break;
                        case 1:
                            left = PnlPlayer1.Left;
                            top = PnlPlayer1.Top;
                            width = PnlPlayer1.Width;
                            break;
                        case 2:
                            left = PnlPlayer2.Left;
                            top = PnlPlayer2.Top;
                            width = PnlPlayer2.Width;
                            break;
                        case 3:
                            left = PnlPlayer3.Left;
                            top = PnlPlayer3.Top;
                            width = PnlPlayer3.Width;
                            break;
                    }
                    if (j == 0)
                    {
                        txtBox.Left = left;
                        txtBox.Top = top - txtBoxOffset - txtBox.Height;
                    }
                    else
                    {
                        txtBox.Left = (left + width) - txtBox.Width;
                        txtBox.Top = top - txtBoxOffset - txtBox.Height;
                    }
                    txtBox.Visible = false;
                    PlayerHandStates[i, j] = txtBox;
                    this.Controls.Add(txtBox);
                    SetPlayerStatesVisibility();
                }
            }
        }

        private void ClearPlayerStates()
        {
            for (int i = 0; i < PlayerHandStates.GetLength(0); i++)
            {
                for (int j = 0; j < PlayerHandStates.GetLength(1); j++)
                {
                    PlayerHandStates[i, j].Text = "";
                    PlayerHandStates[i, j].Visible = false;
                }
            }
        }

        private void SetPlayerStatesVisibility()
        {
            //Max of 4 players with a max of two hands each
            for (int i = 0; i < game.Players.Length; i++)
            {
                if (game.Players[i] != null && game.Players[i].Hand.Count > 0)
                {
                    for (int j = 0; j < game.Players[i].Hand.Count; j++)
                    {
                        //check for the appropriate status to record
                        //Make sure the player has placed a valid bet
                        if (game.Players[i].BetPot.Count > 0 && game.Players[i].BetPot[j].PotValue > 0)
                        {
                            switch (game.Players[i].PlayerStatus[j])
                            {
                                case "Play":
                                    if (game.Players[i].Hand[j].HandValue != null || game.Players[i].Hand[j].HandValue.Count > 0)
                                    {
                                        PlayerHandStates[i, j].Text = "Hand: " + String.Join(":", game.Players[i].Hand[j].HandValue);
                                        break;
                                    }
                                    else
                                    {
                                        PlayerHandStates[i, j].Text = "Hand: " + game.Players[i].Hand[j].HandValue.ToString();
                                        break;
                                    }
                                case "Stay":
                                    PlayerHandStates[i, j].Text = "Hand: " + game.Players[i].Hand[j].HandValue.Max().ToString();
                                    break;
                                case "BlackJack":
                                    PlayerHandStates[i, j].Text = "BlackJack";
                                    break;
                                case "Bust":
                                    PlayerHandStates[i, j].Text = "Bust";
                                    break;
                            }
                            PlayerHandStates[i, j].Visible = true;
                        }
                        else
                        {
                            PlayerHandStates[i, j].Text = "";
                            PlayerHandStates[i, j].Visible = false;
                        }
                    }
                }
            }
        }

        private void AddPlayerBetsTextBox()
        {
            int txtBoxOffset = -8;
            Font font = new Font("Segoe UI", 12, FontStyle.Bold);
            for (int i = 0; i < NUM_PLAYERS; i++)
            {
                for (int j = 0; j < 2; j++) // max of two hands per player
                {
                    TextBox txtBox = new TextBox();
                    txtBox.Font = font;
                    txtBox.BackColor = Color.Black;
                    txtBox.ForeColor = Color.White;
                    txtBox.Width = 100;
                    txtBox.Height = 29;
                    txtBox.TextAlign = HorizontalAlignment.Center;
                    txtBox.ReadOnly = true;
                    txtBox.TabStop = false;
                    txtBox.Name = i.ToString() + j.ToString();
                    //Position each text box
                    int left = 0;
                    int top = 0;
                    int width = 0;

                    switch (i)
                    {
                        case 0:
                            left = PnlPlayer0.Left;
                            top = PnlPlayer0.Top;
                            width = PnlPlayer0.Width;
                            break;
                        case 1:
                            left = PnlPlayer1.Left;
                            top = PnlPlayer1.Top;
                            width = PnlPlayer1.Width;
                            break;
                        case 2:
                            left = PnlPlayer2.Left;
                            top = PnlPlayer2.Top;
                            width = PnlPlayer2.Width;
                            break;
                        case 3:
                            left = PnlPlayer3.Left;
                            top = PnlPlayer3.Top;
                            width = PnlPlayer3.Width;
                            break;
                    }
                    if (j == 0)
                    {
                        txtBox.Left = left;
                        txtBox.Top = top - txtBoxOffset - 2 * txtBox.Height;
                    }
                    else
                    {
                        txtBox.Left = (left + width) - txtBox.Width;
                        txtBox.Top = top - txtBoxOffset - 2 * txtBox.Height;
                    }
                    txtBox.Visible = false;
                    PlayerBets[i, j] = txtBox;
                    this.Controls.Add(txtBox);
                }
            }
        }

        private void ClearPlayerBets()
        {
            for (int i = 0; i < PlayerBets.GetLength(0); i++)
            {
                for (int j = 0; j < PlayerBets.GetLength(1); j++)
                {
                    PlayerBets[i, j].Text = "";
                    PlayerBets[i, j].Visible = false;
                }
            }
        }

        private void SetPlayerBetsVisibility()
        {
            //Max of 4 players with a max of two hands each
            for (int i = 0; i < game.Players.Length; i++)
            {
                if (game.Players[i] != null && game.Players[i].BetPot.Count > 0)
                {
                    for (int j = 0; j < game.Players[i].BetPot.Count; j++)
                    {
                        if (game.Players[i].BetPot[j].PotValue > 0)
                        {
                            PlayerBets[i, j].Text = "Bet: " + game.Players[i].BetPot[j].PotValue.ToString();
                            PlayerBets[i, j].Visible = true;
                        }
                        else
                        {
                            PlayerBets[i, j].Text = "Bet: ";
                            PlayerBets[i, j].Visible = false; ;
                        }

                    }
                }
            }
        }

        private void SetPlayerWinLossState()
        {
            //Max of 4 players with a max of two hands each
            for (int i = 0; i < game.Players.Length; i++)
            {
                if (game.Players[i] != null)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (!game.PlayerWinLossState[i, j].Equals(""))
                        {
                            PlayerBets[i, j].Text = game.PlayerWinLossState[i, j];
                            PlayerBets[i, j].Visible = true;
                        }
                        else
                        {
                            PlayerBets[i, j].Visible = false; ;
                        }

                    }
                }
            }
        }
        private void SetDealerHandState()
        {
            if (game.Dealer.Status.Equals("Play"))
            {
                TxtDealerHandState.Visible = false;
                TxtDealerHandState.Text = "";
            }
            else if (game.Dealer.Status.Equals("BlackJack") || game.Dealer.Status.Equals("Bust"))
            {
                TxtDealerHandState.Visible = true;
                TxtDealerHandState.Text = game.Dealer.Status;
            }
            else if (game.Dealer.Status.Equals("Stay"))
            {
                if (game.Dealer.Hand.HandValue.Max() < 17)
                {
                    TxtDealerHandState.Visible = false;
                    TxtDealerHandState.Text = "";
                }
                else
                {
                    TxtDealerHandState.Visible = true;
                    TxtDealerHandState.Text = game.Dealer.Hand.HandValue.Max().ToString();
                }
            }
        }
        private void ClearDealerState()
        {
            TxtDealerHandState.Text = "";
            TxtDealerHandState.Visible = false;
        }

        private void ShowPotValue()
        {
            for (int i = 0; i < NUM_PLAYERS; i++)
            {
                if (game.Players[i] != null)
                {
                    switch (i)
                    {
                        case 0:
                            LblPotValue0.Visible = true;
                            LblPotValue0.Text = "Pot Value: " + game.Players[i].Pot.PotValue.ToString();
                            break;
                        case 1:
                            LblPotValue1.Visible = true;
                            LblPotValue1.Text = "Pot Value: " + game.Players[i].Pot.PotValue.ToString();
                            break;
                        case 2:
                            LblPotValue2.Visible = true;
                            LblPotValue2.Text = "Pot Value: " + game.Players[i].Pot.PotValue.ToString();
                            break;
                        case 3:
                            LblPotValue3.Visible = true;
                            LblPotValue3.Text = "Pot Value: " + game.Players[i].Pot.PotValue.ToString();
                            break;
                    }
                }
                else
                {
                    switch (i)
                    {
                        case 0:
                            LblPotValue0.Visible = false;
                            LblPotValue0.Text = "Pot Value: ";
                            break;
                        case 1:
                            LblPotValue1.Visible = false;
                            LblPotValue1.Text = "Pot Value: ";
                            break;
                        case 2:
                            LblPotValue2.Visible = false;
                            LblPotValue2.Text = "Pot Value: ";
                            break;
                        case 3:
                            LblPotValue3.Visible = false;
                            LblPotValue3.Text = "Pot Value: ";
                            break;
                    }
                }
            }
        }

        private void CheckPlayersPotValues()
        {
            for (int i = 0; i < NUM_PLAYERS; i++)
            {
                if (game.Players[i] != null && game.Players[i].Pot.PotValue <= 0)
                {
                    //rest bet values
                    switch (i)
                    {
                        case 0:
                            NudHundreds0.Value = 0;
                            NudTens0.Value = 0;
                            NudOnes0.Value = 0;
                            break;
                        case 1:
                            NudHundreds1.Value = 0;
                            NudTens1.Value = 0;
                            NudOnes1.Value = 0;
                            break;
                        case 2:
                            NudHundreds2.Value = 0;
                            NudTens2.Value = 0;
                            NudOnes2.Value = 0;
                            break;
                        case 3:
                            NudHundreds3.Value = 0;
                            NudTens3.Value = 0;
                            NudOnes3.Value = 0;
                            break;
                    }
                    game.Players[i] = null;
                }
            }
        }
        private void CheckDrawPileCount()
        {
            if (game.DrawPile.Cards.Count <= minDrawPileCount)
            {
                game.CombineDiscardWithDrawPile();
                game.DrawPile.Shuffle();
                PicDiscardPile.Image = null;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnHouseRules_Click(object sender, EventArgs e)
        {
            string message = "The DrawPile\r\n";
            message += "Consists of 6 Decks of cards shuffled together.\r\n\r\n";
            message += "Object of the Game\r\n";
            message += "Each participant attempts to beat the dealer by getting a count as close to 21 as possible, without going over 21.\r\n\r\n";
            message += "Card Values/scoring\r\n";
            message += "It is up to each individual player if an ace is worth 1 or 11. Face cards are 10 and any other card is its pip value.\r\n";
            message += "When a player stays and has a hand that may have two values due to an ace the max value <= 21 will be choosen\r\n\r\n";
            message += "Betting\r\n";
            message += "Before the deal begins, each player places a bet.\r\n\r\n";
            message += "Dealer\r\n";
            message += "The dealer must stay if he has between 17 and 21 inclusive. He must take another card if he has less than 17\r\n\r\n";
            message += "BlackJack\r\n";
            message += "If an Ace and a (King, Queen, Jack or 10) is dealt with the first two cards the player/Dealer has a BlackJack\r\n\r\n";
            message += "Splitting\r\n";
            message += "A player may split their hand after the initial deal if the card pairs are the same and if they have enough in their pot.\r\n";
            message += "BlackJack is allowed on splitting\r\n\r\n";
            message += "Doubling Down\r\n";
            message += "A player may double down after the initial deal if the sum of the value of the two cards equal 10 or 11 and their is enough in their pot.\r\n";
            message += "On doubling down the player will only receive one more card and then has to stay\r\n\r\n";
            message += "Reshuffling\r\n";
            message += "Once their are approximately 20% of the original draw pile left, the dicard pile will be combined with the draw pile and reshuffled\r\n";



            MessageBox.Show(message);
        }
    }
}