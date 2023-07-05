namespace SnakesAndLadders
{
    public class SLBoard
    {
        public int NumberOfPlayers { get; private set; }
        public int CurrentPlayer { get; set; }
        public Panel GamePanel { get; private set; }
        public List<BoardTile> Tiles { get; private set; }
        public Player[] Players { get; private set; }
        public Dictionary<int, int> Ladders { get; set; } //set from client side
        public Dictionary<int, int> Snakes { get; set; } //set from client side
        public bool TileOneOnLeftSide { get; private set; } //default

        private int panelHeight;
        private int panelWidth;
        private int numRows;
        private int numCols;        

        private const int MAX_PLAYERS = 4;

        public SLBoard(Panel gamePanel, int numRows, int numCols, int numPlayers, bool tileOneOnLeftSide)
        {
            //Max of four players allowed
            if (numPlayers > MAX_PLAYERS)
            {
                NumberOfPlayers = MAX_PLAYERS;
            }
            else
            {
                NumberOfPlayers = numPlayers;
            }

            GamePanel = gamePanel;
            //Get width and height of Game Panel
            panelWidth = GamePanel.Width;
            panelHeight = GamePanel.Height;

            //Get number of rows and columns the board needs
            this.numRows = numRows;
            this.numCols = numCols;

            Ladders = new Dictionary<int, int>();
            Snakes = new Dictionary<int, int>();

            TileOneOnLeftSide = tileOneOnLeftSide;

            if (TileOneOnLeftSide)
            {
                AddBoardTilesFromLeft();
            }
            else
            {
                AddBoardTilesFromRight();
            }

            NewGame();
        }

        /// <summary>
        /// Setup the game board base on the game panel width and height
        /// and the number of cols and rows needed
        /// </summary>
        private void AddBoardTilesFromLeft()
        {
            //List of board squares that follow
            //the layout of the Snakes and ladders
            //image with regards to X,Y positions
            //and board square number
            int position = 0;
            int width = panelWidth / numCols;
            int height = panelHeight / numRows;
            int x = 0;
            int y;
            Tiles = new List<BoardTile>();

            for (int i = 1; i <= numRows; i++)
            {
                y = panelHeight - height * i;
                //Check if even or odd row number
                if (i % 2 != 0) //ODD row number
                {
                    //Increment to the right
                    for (int j = 0; j < numCols; j++)
                    {
                        x = width * j;
                        position++;
                        BoardTile tile = new BoardTile(x, y, width, height, position);
                        Tiles.Add(tile);
                    }
                }
                else//EVEN row number
                {
                    //Increment to the left
                    for (int j = numCols - 1; j >= 0; j--)
                    {
                        x = width * j;
                        position++;
                        BoardTile tile = new BoardTile(x, y, width, height, position);
                        Tiles.Add(tile);
                    }
                }

            }
        }

        private void AddBoardTilesFromRight()
        {
            //List of board squares that follow
            //the layout of the Snakes and ladders
            //image with regards to X,Y positions
            //and board square number
            int position = 0;
            int width = panelWidth / numCols;
            int height = panelHeight / numRows;
            int x = panelWidth - width;
            int y;
            Tiles = new List<BoardTile>();

            for (int i = 1; i <= numRows; i++)
            {
                y = panelHeight - height * i;
                //Check if even or odd row number
                if (i % 2 != 0) //ODD row number
                {
                    //Increment to the left
                    for (int j = numCols - 1; j >= 0; j--)
                    {
                        x = width * j;
                        position++;
                        BoardTile tile = new BoardTile(x, y, width, height, position);
                        Tiles.Add(tile);
                    }
                }
                else//EVEN row number
                {
                    //Increment to the right
                    for (int j = 0; j < numCols; j++)
                    {
                        x = width * j;
                        position++;
                        BoardTile tile = new BoardTile(x, y, width, height, position);
                        Tiles.Add(tile);
                    }
                }

            }
        }

        /// <summary>
        /// Sets up the players on the game panel passed in
        /// </summary>
        public void NewGame()
        {
            //Add players
            Players = new Player[NumberOfPlayers];
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
                        Players[i] = new Player(playerWidth, playerHeight, tile.X, tile.Y, xOffset, yOffset, Color.Red, "1");
                        Players[i].Font = new Font("Courier New", 18, FontStyle.Bold);
                        break;
                    case 1:
                        xOffset = 0;
                        yOffset = tile.Height / 2;
                        Players[i] = new Player(playerWidth, playerHeight, tile.X, tile.Y, xOffset, yOffset, Color.DarkCyan, "2");
                        Players[i].Font = new Font("Courier New", 18, FontStyle.Bold);
                        break;
                    case 2:
                        xOffset = tile.Width / 2;
                        yOffset = 0;
                        Players[i] = new Player(playerWidth, playerHeight, tile.X, tile.Y, xOffset, yOffset, Color.YellowGreen, "3");
                        Players[i].Font = new Font("Courier New", 18, FontStyle.Bold);
                        break;
                    case 3:
                        xOffset = tile.Width / 2;
                        yOffset = tile.Height / 2;
                        Players[i] = new Player(playerWidth, playerHeight, tile.X, tile.Y, xOffset, yOffset, Color.LimeGreen, "4");
                        Players[i].Font = new Font("Courier New", 18, FontStyle.Bold);
                        break;
                }
                GamePanel.Controls.Add(Players[i]);
            }
        }

        /// <summary>
        /// Disposes of all players in Players
        /// </summary>
        public void ClearPlayers()
        {
            foreach (Player player in Players)
            {
                player.Dispose();
            }
        }

        /// <summary>
        /// Returns the current player
        /// </summary>
        /// <returns></returns>
        public Player CurrentPlayerData()
        {
            return Players[CurrentPlayer - 1];
        }

        /// <summary>
        /// Returns the current players position on the board
        /// </summary>
        /// <returns></returns>
        public int CurrentPlayerPosition()
        {
            return Players[CurrentPlayer - 1].BoardPosition;
        }

        /// <summary>
        /// Moves a player to any square on the board
        /// </summary>
        /// <param name="player"></param>
        /// <param name="index"></param>
        /// Index is the index of the board square to move to
        public void SetPlayerBoardPosition(Player player, int index)
        {
            BoardTile tile = Tiles[index];
            int left = tile.X;
            int top = tile.Y;
            player.CounterMove(left, top);
            player.BoardPosition = tile.Position;
            player.Refresh();
        }

        /// <summary>
        /// Moves a player from their current position to
        /// any another x,y position
        /// </summary>
        /// <param name="player"></param>
        /// <param name="deltaX"></param>
        /// <param name="deltaY"></param>
        public void MovePlayerIncrementally(Player player, int deltaX, int deltaY)
        {
            int left = player.Left;
            int top = player.Top;
            int xOffset = player.XOffset;
            int yOffset = player.YOffset;
            player.CounterMove(left - xOffset + deltaX, top - yOffset + deltaY);
            player.Refresh();
        }

        /// <summary>
        /// Moves the current player one square forward
        /// </summary>
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

        /// <summary>
        /// Moves the current player one square back
        /// </summary>
        public void MovePlayerBackward()
        {
            //Moves the player one sqare back
            int currentPosition = Players[CurrentPlayer - 1].BoardPosition;
            BoardTile tile = Tiles[currentPosition - 2];
            int left = tile.X;
            int top = tile.Y;
            Players[CurrentPlayer - 1].CounterMove(left, top);
            Players[CurrentPlayer - 1].BoardPosition = tile.Position;
            Players[CurrentPlayer - 1].Refresh();
        }

        /// <summary>
        /// Checks if the last square has been reach by the current player
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Checks if the player position is at the base of a ladder
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public bool IsLadder(Player player)
        {
            if (Ladders.ContainsKey(player.BoardPosition))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks if the player position is at the head of a snake
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public bool IsSnake(Player player)
        {
            if (Snakes.ContainsKey(player.BoardPosition))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns the board position of the top of a ladder
        /// given the base if it is valid other wise it returns -1
        /// Use IsLadder to check first
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public int GetLadderTop(int ladderPosition)
        {
            if (Ladders.ContainsKey(ladderPosition))
            {
                return Ladders[ladderPosition];
            }
            return -1;
        }

        /// <summary>
        /// Returns the board position of the tail of a snake
        /// given the head of the snake if it is valid other wise it returns -1
        /// Use IsSnake to check first
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public int GetSnakeTail(int snakePosition)
        {
            if (Snakes.ContainsKey(snakePosition))
            {
                return Snakes[snakePosition];
            }
            return -1;
        }
    }
}
