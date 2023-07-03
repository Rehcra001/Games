using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnakesAndLadders;

namespace GamesWinFormsUI
{
    public partial class frmSnakesAndLadders : Form
    {
        public frmSnakesAndLadders()
        {
            InitializeComponent();
        }

        private SoundPlayer moveSound;
        private SoundPlayer rollDieSound;
        private SoundPlayer fallingSound;
        private SoundPlayer climbingSound;
        private Die die = new Die(6); //six sided die
        private int numMoves; //number of steps to move
        private int deltaX; //number of pixels to move along the X axis
        private int deltaY; //number of pixels to move along the Y axis
        private int destinationIndex; //board square destination when moving up ladders or down snakes
        private Counter currentPlayer;
        private bool gameStarted = false;
        private bool endOfBoardReached = false;
        private bool playSounds;

        SLBoard board;
        private void FrmSnakesAndLadders_Load(object sender, EventArgs e)
        {
            SetupBoard();

            lblPlayer1.Visible = true;
            lblPlayerOneSquare.Visible = true;

            lblPlayer2.Visible = false;
            lblPlayerTwoSquare.Visible = false;

            lblPlayer3.Visible = false;
            lblPlayerThreeSquare.Visible = false;

            lblPlayer4.Visible = false;
            lblPlayerFourSquare.Visible = false;

            btnRollDie.Enabled = false;
            btnReset.Enabled = false;

            try
            {
                moveSound = new SoundPlayer(Properties.Resources.bounce);
                rollDieSound = new SoundPlayer(Properties.Resources.DieRoll);
                fallingSound = new SoundPlayer(Properties.Resources.falling);
                climbingSound = new SoundPlayer(Properties.Resources.climbing);
                playSounds = true;
            }
            catch (Exception)
            {
                playSounds = false;
            }
        }

        private void RdoPlayers_Click(object sender, EventArgs e)
        {
            ClearAndAddNew();
        }

        private void BtnRollDie_Click(object sender, EventArgs e)
        {
            //btnRollDie.Enabled = false;
            PlayRollDieSound();
            timRollStart.Enabled = true;
            timRollStop.Enabled = true;
        }

        private void TimRollStop_Tick(object sender, EventArgs e)
        {

            timRollStart.Enabled = false;
            timRollStop.Enabled = false;
            timMovePlayer.Enabled = true;
        }

        private void TimRollStart_Tick(object sender, EventArgs e)
        {
            numMoves = die.GetValue();
            switch (numMoves)
            {
                case 1:
                    picDieRoll.Image = picDie1.Image;
                    break;
                case 2:
                    picDieRoll.Image = picDie2.Image;
                    break;
                case 3:
                    picDieRoll.Image = picDie3.Image;
                    break;
                case 4:
                    picDieRoll.Image = picDie4.Image;
                    break;
                case 5:
                    picDieRoll.Image = picDie5.Image;
                    break;
                case 6:
                    picDieRoll.Image = picDie6.Image;
                    break;
            }
        }

        private void TimMovePlayer_Tick(object sender, EventArgs e)
        {
            if (!board.EndOfBoardReached() && !endOfBoardReached)
            {
                board.MovePlayerForward();
            }
            else
            {
                endOfBoardReached = true;
                board.MovePlayerBackward();
            }
            PlayMoveSound();
            numMoves--;
            if (numMoves <= 0)
            {
                timMovePlayer.Enabled = false;
                if (board.EndOfBoardReached())
                {
                    MessageBox.Show("Player " + board.CurrentPlayer.ToString() + " WINS!!!", "Game Over",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnReset.PerformClick();
                }
                else
                {
                    //check if snake or ladder on block
                    //if yes then move it to corresponding block
                    //and set position
                    SnakeOrLadder();
                    if (board.CurrentPlayer < board.NumberOfPlayers)
                    {
                        board.CurrentPlayer++;
                        UpdatePlayerProgress();
                        NextPlayer();
                    }
                    else
                    {
                        board.CurrentPlayer = 1;
                        UpdatePlayerProgress();
                        NextPlayer();
                    }
                }
                endOfBoardReached = false;
            }
        }

        private void TimLadder_Tick(object sender, EventArgs e)
        {
            if (numMoves <= 0)
            {
                board.SetPlayerBoardPosition(currentPlayer, destinationIndex);
                timLadder.Enabled = false;
                climbingSound.Stop();
                UpdatePlayerProgress();
                NextPlayer();
            }
            else
            {
                board.MovePlayerIncrementally(currentPlayer, deltaX, deltaY);
                numMoves--;
            }
        }

        private void timSnake_Tick(object sender, EventArgs e)
        {
            if (numMoves <= 0)
            {
                board.SetPlayerBoardPosition(currentPlayer, destinationIndex);
                timSnake.Enabled = false;
                fallingSound.Stop();
                UpdatePlayerProgress();
                NextPlayer();
            }
            else
            {
                board.MovePlayerIncrementally(currentPlayer, deltaX, deltaY);
                numMoves--;
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            grpNumberOfPlayers.Enabled = false;
            btnRollDie.Enabled = true;
            btnReset.Enabled = true;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            grpNumberOfPlayers.Enabled = true;
            btnRollDie.Enabled = false;
            btnReset.Enabled = false;
            ClearAndAddNew();
            UpdatePlayerProgress();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            string helpMessage = "1: Select the number of Players and press Start.\r\n";
            helpMessage += "2: Press the Roll Die button to have the current player move.\r\n";
            helpMessage += "3: To restart the game press the Reset button.\r\n";
            helpMessage += "\r\nRULES:\r\n";
            helpMessage += "- The game allows for one to four players.\r\n";
            helpMessage += "- Player 1 always moves first followed by Player 2 etc...\r\n";
            helpMessage += "- The first player to reach the last square wins.\r\n";
            helpMessage += "- To land on the last square the exact number of moves must be rolled\r\n";
            helpMessage += "  or else the Player will move backward on the board.\r\n";
            helpMessage += "- If you land on the base of a ladder you will move to the top of the ladder.\r\n";
            helpMessage += "- If you land on the head of a snake you will slide down to the tail of the snake.\r\n";
            helpMessage += "\r\nENJOY!!!\r\n";
            MessageBox.Show(helpMessage);
        }

        private void SetupBoard()
        {
            board = new SLBoard(pnlGamePanel, NumberOfPlayers());
            board.CurrentPlayer = 1;
        }

        private void ClearAndAddNew()
        {
            if (!gameStarted)
            {
                board.ClearPlayers();
                SetupBoard();

                switch (NumberOfPlayers())
                {
                    case 1:
                        lblPlayer1.Visible = true;
                        lblPlayerOneSquare.Visible = true;

                        lblPlayer2.Visible = false;
                        lblPlayerTwoSquare.Visible = false;

                        lblPlayer3.Visible = false;
                        lblPlayerThreeSquare.Visible = false;

                        lblPlayer4.Visible = false;
                        lblPlayerFourSquare.Visible = false;
                        break;
                    case 2:
                        lblPlayer1.Visible = true;
                        lblPlayerOneSquare.Visible = true;

                        lblPlayer2.Visible = true;
                        lblPlayerTwoSquare.Visible = true;

                        lblPlayer3.Visible = false;
                        lblPlayerThreeSquare.Visible = false;

                        lblPlayer4.Visible = false;
                        lblPlayerFourSquare.Visible = false;
                        break;
                    case 3:
                        lblPlayer1.Visible = true;
                        lblPlayerOneSquare.Visible = true;

                        lblPlayer2.Visible = true;
                        lblPlayerTwoSquare.Visible = true;

                        lblPlayer3.Visible = true;
                        lblPlayerThreeSquare.Visible = true;

                        lblPlayer4.Visible = false;
                        lblPlayerFourSquare.Visible = false;
                        break;
                    case 4:
                        lblPlayer1.Visible = true;
                        lblPlayerOneSquare.Visible = true;

                        lblPlayer2.Visible = true;
                        lblPlayerTwoSquare.Visible = true;

                        lblPlayer3.Visible = true;
                        lblPlayerThreeSquare.Visible = true;

                        lblPlayer4.Visible = true;
                        lblPlayerFourSquare.Visible = true;
                        break;
                }
            }
        }

        private int NumberOfPlayers()
        {
            string playerCount = "";
            foreach (RadioButton numPlayers in grpNumberOfPlayers.Controls)
            {
                if (numPlayers.Checked)
                {
                    playerCount = numPlayers.Text;
                    break;
                }
            }

            switch (playerCount)
            {
                case "Single Player":
                    return 1;
                case "Two Players":
                    return 2;
                case "Three Players":
                    return 3;
                case "Four Players":
                    return 4;
                default:
                    return -1;
            }
        }

        private void SnakeOrLadder()
        {
            int currentTileIndex = board.CurrentPlayerPosition();

            switch (currentTileIndex)
            {
                case 2:
                    CalcNumberOfMoves(board.Tiles[1], board.Tiles[22]);
                    calcDeltaX(board.Tiles[1], board.Tiles[22]);
                    calcDeltaY(board.Tiles[1], board.Tiles[22]);
                    currentPlayer = board.CurrentPlayerCounter();
                    destinationIndex = 22;
                    PlayClimbingSound();
                    timLadder.Enabled = true;
                    break;
                case 6:
                    CalcNumberOfMoves(board.Tiles[5], board.Tiles[44]);
                    calcDeltaX(board.Tiles[5], board.Tiles[44]);
                    calcDeltaY(board.Tiles[5], board.Tiles[44]);
                    currentPlayer = board.CurrentPlayerCounter();
                    destinationIndex = 44;
                    PlayClimbingSound();
                    timLadder.Enabled = true;
                    break;
                case 20:
                    CalcNumberOfMoves(board.Tiles[19], board.Tiles[58]);
                    calcDeltaX(board.Tiles[19], board.Tiles[58]);
                    calcDeltaY(board.Tiles[19], board.Tiles[58]);
                    currentPlayer = board.CurrentPlayerCounter();
                    destinationIndex = 58;
                    PlayClimbingSound();
                    timLadder.Enabled = true;
                    break;
                case 52:
                    CalcNumberOfMoves(board.Tiles[51], board.Tiles[71]);
                    calcDeltaX(board.Tiles[51], board.Tiles[71]);
                    calcDeltaY(board.Tiles[51], board.Tiles[71]);
                    currentPlayer = board.CurrentPlayerCounter();
                    destinationIndex = 71;
                    PlayClimbingSound();
                    timLadder.Enabled = true;
                    break;
                case 57:
                    CalcNumberOfMoves(board.Tiles[56], board.Tiles[95]);
                    calcDeltaX(board.Tiles[56], board.Tiles[95]);
                    calcDeltaY(board.Tiles[56], board.Tiles[95]);
                    currentPlayer = board.CurrentPlayerCounter();
                    destinationIndex = 95;
                    PlayClimbingSound();
                    timLadder.Enabled = true;
                    break;
                case 71:
                    CalcNumberOfMoves(board.Tiles[70], board.Tiles[91]);
                    calcDeltaX(board.Tiles[70], board.Tiles[91]);
                    calcDeltaY(board.Tiles[70], board.Tiles[91]);
                    currentPlayer = board.CurrentPlayerCounter();
                    destinationIndex = 91;
                    PlayClimbingSound();
                    timLadder.Enabled = true;
                    break;
                case 43:
                    CalcNumberOfMoves(board.Tiles[42], board.Tiles[16]);
                    calcDeltaX(board.Tiles[42], board.Tiles[16]);
                    calcDeltaY(board.Tiles[42], board.Tiles[16]);
                    currentPlayer = board.CurrentPlayerCounter();
                    destinationIndex = 16;
                    PlayFallingSound();
                    timSnake.Enabled = true;
                    break;
                case 50:
                    CalcNumberOfMoves(board.Tiles[49], board.Tiles[4]);
                    calcDeltaX(board.Tiles[49], board.Tiles[4]);
                    calcDeltaY(board.Tiles[49], board.Tiles[4]);
                    currentPlayer = board.CurrentPlayerCounter();
                    destinationIndex = 4;
                    PlayFallingSound();
                    timSnake.Enabled = true;
                    break;
                case 56:
                    CalcNumberOfMoves(board.Tiles[55], board.Tiles[7]);
                    calcDeltaX(board.Tiles[55], board.Tiles[7]);
                    calcDeltaY(board.Tiles[55], board.Tiles[7]);
                    currentPlayer = board.CurrentPlayerCounter();
                    destinationIndex = 7;
                    PlayFallingSound();
                    timSnake.Enabled = true;
                    break;
                case 73:
                    CalcNumberOfMoves(board.Tiles[72], board.Tiles[14]);
                    calcDeltaX(board.Tiles[72], board.Tiles[14]);
                    calcDeltaY(board.Tiles[72], board.Tiles[14]);
                    currentPlayer = board.CurrentPlayerCounter();
                    destinationIndex = 14;
                    PlayFallingSound();
                    timSnake.Enabled = true;
                    break;
                case 84:
                    CalcNumberOfMoves(board.Tiles[83], board.Tiles[57]);
                    calcDeltaX(board.Tiles[83], board.Tiles[57]);
                    calcDeltaY(board.Tiles[83], board.Tiles[57]);
                    currentPlayer = board.CurrentPlayerCounter();
                    destinationIndex = 57;
                    PlayFallingSound();
                    timSnake.Enabled = true;
                    break;
                case 87:
                    CalcNumberOfMoves(board.Tiles[86], board.Tiles[48]);
                    calcDeltaX(board.Tiles[86], board.Tiles[48]);
                    calcDeltaY(board.Tiles[86], board.Tiles[48]);
                    currentPlayer = board.CurrentPlayerCounter();
                    destinationIndex = 48;
                    PlayFallingSound();
                    timSnake.Enabled = true;
                    break;
                case 98:
                    CalcNumberOfMoves(board.Tiles[97], board.Tiles[39]);
                    calcDeltaX(board.Tiles[97], board.Tiles[39]);
                    calcDeltaY(board.Tiles[97], board.Tiles[39]);
                    currentPlayer = board.CurrentPlayerCounter();
                    destinationIndex = 39;
                    PlayFallingSound();
                    timSnake.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void CalcNumberOfMoves(BoardTile tileStart, BoardTile tileEnd)
        {
            //move 5 pixels at a time in Y
            int numPixels = 5;
            int y = tileStart.Y - tileEnd.Y;
            numMoves = (int)Math.Abs(y / numPixels);
        }
        private void calcDeltaX(BoardTile tileStart, BoardTile tileEnd)
        {
            deltaX = (tileEnd.X - tileStart.X) / numMoves;
        }

        private void calcDeltaY(BoardTile tileStart, BoardTile tileEnd)
        {
            deltaY = (tileEnd.Y - tileStart.Y) / numMoves;
        }

        private void NextPlayer()
        {
            lblNextPlayer.Text = $"Player {board.CurrentPlayer} to Roll Next";
        }

        private void UpdatePlayerProgress()
        {
            int num = NumberOfPlayers();

            for (int i = 0; i < num; i++)
            {
                if (i == 0)
                {
                    lblPlayerOneSquare.Text = board.Players[i].BoardPosition.ToString();
                }
                if (i == 1)
                {
                    lblPlayerTwoSquare.Text = board.Players[i].BoardPosition.ToString();
                }
                if (i == 2)
                {
                    lblPlayerThreeSquare.Text = board.Players[i].BoardPosition.ToString();
                }
                if (i == 3)
                {
                    lblPlayerFourSquare.Text = board.Players[i].BoardPosition.ToString();
                }
            }
        }

        //Sound only to be played if loaded correctly
        private void PlayMoveSound()
        {
            if (playSounds)
            {
                moveSound.Play();
            }
        }
        private void PlayRollDieSound()
        {
            if (playSounds)
            {
                rollDieSound.Play();
            }
        }
        private void PlayFallingSound()
        {
            if (playSounds)
            {
                fallingSound.Play();
            }
        }
        private void PlayClimbingSound()
        {
            if (playSounds)
            {
                climbingSound.Play();
            }
        }


    }
}
