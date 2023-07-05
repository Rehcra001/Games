using System.Media;
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
        private Player currentPlayer;
        private bool gameStarted = false;
        private bool endOfBoardReached = false;
        private bool playSounds;
        private bool defaultGame = true;

        SLBoard board;
        private void FrmSnakesAndLadders_Load(object sender, EventArgs e)
        {
            StartDefaultGame();

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

        private void StartDefaultGame()
        {
            //Read in default snakes and ladder parameters
            int rows;
            int columns;
            string[] parameters = Properties.Resources.SnakesAndLaddersDefaultGame.Split("\r\n");

            //Example of input file for starting a game

            //# Image file
            //C:\\User\\....\\?.png or any other supported image file
            //# Width and Height
            //700,700
            //#Number of rows and columns
            //10,10
            //#Ladders
            //2,23
            //6,45
            //20,59
            //52,72
            //57,96
            //71,92
            //#Snakes
            //43,17
            //50,5
            //56,8
            //73,15
            //84,58
            //87,49
            //98,40

            //Read in width and height of panel
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i] == "#Width and Height")
                {
                    i++;
                    string[] widthHeight = parameters[i].Split(',');
                    pnlGamePanel.Width = Convert.ToInt32(widthHeight[0]);
                    pnlGamePanel.Height = Convert.ToInt32(widthHeight[1]);
                    break;
                }
            }

            //Read in the rows and columns
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i] == "#Number of rows and columns")
                {
                    i++;
                    string[] rowColumn = parameters[i].Split(',');
                    rows = Convert.ToInt32(rowColumn[0]);
                    columns = Convert.ToInt32(rowColumn[1]);

                    //create the board
                    board = new SLBoard(pnlGamePanel, rows, columns, NumberOfPlayers(), true);
                    board.CurrentPlayer = 1;
                    break;
                }
            }
            
            //Read in Ladders and Snakes
            //loop through parameters until #Ladders is found
            int index;
            for (int i = 0; i < parameters.Length; i++)
            {
                
                if (parameters[i] == "#Ladders")
                {
                    index = i + 1;
                    //Read in Ladders
                    while (parameters[index] != "#Snakes")
                    {                        
                        string[] ladders = parameters[index].Split(',');
                        board.Ladders.Add(Convert.ToInt32(ladders[0]), Convert.ToInt32(ladders[1]));
                        index++;
                    }
                    //Read in Snakes
                    index++;
                    while (index < parameters.Length)
                    {                        
                        string[] snakes = parameters[index].Split(',');
                        board.Snakes.Add(Convert.ToInt32(snakes[0]), Convert.ToInt32(snakes[1]));
                        index++;
                    }
                    break;
                }
            }
        }

        private void ClearAndAddNew()
        {
            if (!gameStarted)
            {
                board.ClearPlayers();
                if (defaultGame)
                {
                    StartDefaultGame();
                }
                {
                    //If a loaded game is being played
                    //reload the same game
                }                

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
            if (board.IsLadder(board.CurrentPlayerData()))
            {
                int start = board.CurrentPlayerPosition();
                int end = board.Ladders[start];
                CalcNumberOfMoves(board.Tiles[start - 1], board.Tiles[end - 1]);
                calcDeltaX(board.Tiles[start - 1], board.Tiles[end - 1]);
                calcDeltaY(board.Tiles[start - 1], board.Tiles[end - 1]);
                currentPlayer = board.CurrentPlayerData();
                destinationIndex = end - 1;
                PlayClimbingSound();
                timLadder.Enabled = true;
            }
            else if (board.IsSnake(board.CurrentPlayerData()))
            {
                int start = board.CurrentPlayerPosition();
                int end = board.Snakes[start];
                CalcNumberOfMoves(board.Tiles[start - 1], board.Tiles[end - 1]);
                calcDeltaX(board.Tiles[start - 1], board.Tiles[end - 1]);
                calcDeltaY(board.Tiles[start - 1], board.Tiles[end - 1]);
                currentPlayer = board.CurrentPlayerData();
                destinationIndex = end - 1;
                PlayFallingSound();
                timSnake.Enabled = true;
            }
        }

        private void CalcNumberOfMoves(BoardTile tileStart, BoardTile tileEnd)
        {
            //move 5 pixels at a time in Y
            int numPixels = 7;
            int y = tileStart.Y - tileEnd.Y;
            numMoves = (int)Math.Abs(y / numPixels);
        }
        private void calcDeltaX(BoardTile tileStart, BoardTile tileEnd)
        {
            deltaX = (int)(((float)tileEnd.X - (float)tileStart.X) / (float)numMoves);
        }

        private void calcDeltaY(BoardTile tileStart, BoardTile tileEnd)
        {
            deltaY = (int)(((float)tileEnd.Y - (float)tileStart.Y) / (float)numMoves);
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
