using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class SLBoard
    {
        public int NumberOfPlayers { get; set; }
        public int CurrentPlayer { get; set; }
        public Panel GamePanel { get; set; }
        public List<BoardTile> Tiles { get; private set; }
        public Counter[] Players { get; private set; }

        private int PanelHeight;
        private int PanelWidth;

        private const int NUM_ROWS = 10;
        private const int NUM_COLS = 10;

        public SLBoard(Panel gamePanel, int numPlayers = 1)
        {
            //Max of four players allowed
            if (numPlayers > 4)
            {
                NumberOfPlayers = 4;
            }
            else
            {
                NumberOfPlayers = numPlayers;
            }

            GamePanel = gamePanel;
            //Get width and height of Game Panel
            PanelWidth = GamePanel.Width;
            PanelHeight = GamePanel.Height;

            AddBoardTiles();

            NewGame();
        }

        public void NewGame()
        {
            //Add players
            Players = new Counter[NumberOfPlayers];
            BoardTile tile = Tiles[0];
            int playerHeight = tile.Height / 2 - 2;
            int playerWidth = tile.Width / 2 - 2;

            for (int i = 0; i < NumberOfPlayers; i++)
            {
                //top row (player 1 and player 3)
                //player 2 and 4 go to the bottom row
                int xOffset;
                int yOffset;
                switch (i)
                {
                    case 0:
                        xOffset = 0;
                        yOffset = 0;
                        Players[i] = new Counter(playerWidth, playerHeight, tile.X, tile.Y,xOffset, yOffset, Color.Red, "1");
                        Players[i].Font = new Font("Courier New", 18, FontStyle.Bold);
                        break;
                    case 1:
                        xOffset = 0;
                        yOffset = tile.Height / 2;
                        Players[i] = new Counter(playerWidth, playerHeight, tile.X, tile.Y, xOffset, yOffset, Color.DarkCyan, "2");
                        Players[i].Font = new Font("Courier New", 18, FontStyle.Bold);
                        break;
                    case 2:
                        xOffset = tile.Width / 2;
                        yOffset = 0;
                        Players[i] = new Counter(playerWidth, playerHeight, tile.X, tile.Y, xOffset, yOffset, Color.YellowGreen, "3");
                        Players[i].Font = new Font("Courier New", 18, FontStyle.Bold);
                        break;
                    case 3:
                        xOffset = tile.Width / 2;
                        yOffset = tile.Height / 2;
                        Players[i] = new Counter(playerWidth, playerHeight, tile.X, tile.Y, xOffset, yOffset, Color.LimeGreen, "4");
                        Players[i].Font = new Font("Courier New", 18, FontStyle.Bold);
                        break;
                }
                GamePanel.Controls.Add(Players[i]);
            }
        }

        public void ClearPlayers()
        {
            foreach (Counter player in Players)
            {
                player.Dispose();
            }
        }

        public Counter CurrentPlayerCounter()
        {
            return Players[CurrentPlayer - 1];
        }

        public void SetPlayerBoardPosition(Counter player, int index)
        {            
            BoardTile tile = Tiles[index];
            int left = tile.X;
            int top = tile.Y;
            player.CounterMove(left, top);
            player.BoardPosition = tile.Position;
            player.Refresh();
        }

        public void MovePlayerIncrementally(Counter player, int deltaX, int deltaY)
        {
            int left = player.Left;
            int top = player.Top;
            int xOffset = player.XOffset;
            int yOffset = player.YOffset;
            player.CounterMove(left - xOffset + deltaX, top - yOffset + deltaY);
        }

        public void MovePlayerForward()
        {
            int currentPosition = Players[CurrentPlayer - 1].BoardPosition;
            BoardTile tile = Tiles[currentPosition];
            int left = tile.X;
            int top = tile.Y;
            Players[CurrentPlayer - 1].CounterMove(left, top);
            Players[CurrentPlayer - 1].BoardPosition = tile.Position;
            Players[CurrentPlayer - 1].Refresh();
        }
        public void MovePlayerBackward()
        {
            //Moves the player counters one position back
            int currentPosition = Players[CurrentPlayer - 1].BoardPosition;
            BoardTile tile = Tiles[currentPosition - 2];
            int left = tile.X;
            int top = tile.Y;
            Players[CurrentPlayer - 1].CounterMove(left, top);
            Players[CurrentPlayer - 1].BoardPosition = tile.Position;
            Players[CurrentPlayer - 1].Refresh();
        }

        public bool EndOfBoardReached()
        {
            //Check if the last board tile has been reached
            //if yes and number of moves left is not 0
            //then moveback number of moves left
            if (Players[CurrentPlayer - 1].BoardPosition == Tiles.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void AddBoardTiles()
        {
            //List of board squares that follow
            //the layout of the Snakes and ladders
            //image with regards to X,Y positions
            //and board square number
            int position = 0;
            int width = PanelWidth / NUM_COLS;
            int height = PanelHeight / NUM_ROWS;
            int x = 0;
            int y;
            Tiles = new List<BoardTile>();

            for (int i = 1; i <= NUM_ROWS; i++)
            {
                y = PanelHeight - height * i;
                //Check if even or odd row number
                if (i % 2 != 0) //ODD row number
                {
                    //Increment to the right
                    for (int j = 0; j < NUM_COLS; j++)
                    {
                        x = width * j;
                        position++;
                        BoardTile tile = new BoardTile(x, y, width, height, position);
                        Tiles.Add(tile);
                    }
                }
                else//EVEN row number
                {
                    //Decrement to the left
                    for (int j = NUM_COLS - 1; j >= 0; j--)
                    {
                        x = width * j;
                        position++;
                        BoardTile tile = new BoardTile(x, y, width, height, position);
                        Tiles.Add(tile);
                    }
                }
                
            }
        }
        public int CurrentPlayerPosition()
        {
            return Players[CurrentPlayer - 1].BoardPosition;
        }
    }
}
