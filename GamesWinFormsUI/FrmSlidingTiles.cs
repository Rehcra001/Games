using SlidingTilesPuzzle;
using System.Media;

namespace GamesWinFormsUI
{
    public partial class frmSlidingTiles : Form
    {
        public frmSlidingTiles()
        {
            InitializeComponent();
        }

        private SlidingTiles gameTiles;
        private int gridSize;
        private List<PictureBox> picTiles;
        private bool gameStarted = false;
        private Image tilesImage;
        SoundPlayer moveTile;


        private void FrmSlidingTiles_Load(object sender, EventArgs e)
        {
            tilesImage = picChoice0.Image;
            gridSize = (int)nudGridSize.Value;
            gameTiles = new SlidingTiles(tilesImage, gridSize);
            moveTile = new SoundPlayer(Properties.Resources.snap);
            AddGrid();
        }

        private void NudGridSize_ValueChanged(object sender, EventArgs e)
        {
            if (!gameStarted)
            {
                gridSize = (int)nudGridSize.Value;
                gameTiles = new SlidingTiles(tilesImage, gridSize);
                ClearAndAddNew();
            }

        }

        private void PicChoice_Click(object sender, EventArgs e)
        {
            if (!gameStarted)
            {
                tilesImage = ((PictureBox)sender).Image;
                gameTiles = new SlidingTiles(tilesImage, gridSize);
                ClearAndAddNew();
            }

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnReset.Enabled = true;
            gameStarted = true;
            nudGridSize.Enabled = false;
            gameTiles.Tiles.shuffle();
            ClearAndAddNew();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnReset.Enabled = false;
            gameStarted = false;
            nudGridSize.Enabled = true;
            gameTiles.Tiles.Sort();
            ClearAndAddNew();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PicTiles_Click(object sender, EventArgs e)
        {
            if (gameStarted)
            {
                int indexClicked = Convert.ToInt32(((PictureBox)sender).Name);

                if (gameTiles.IsReachable(indexClicked))
                {
                    if (chkSound.Checked)
                    {
                        moveTile.Play();
                    }
                    int maxValIndex = gameTiles.IndexOfTileValue(gridSize * gridSize - 1);
                    (picTiles[indexClicked].Image, picTiles[maxValIndex].Image) = (picTiles[maxValIndex].Image, picTiles[indexClicked].Image);
                    gameTiles.Tiles.SwapTile(indexClicked, maxValIndex);
                }
                //After each valid move check if puzzle solved
                if (gameTiles.Tiles.IsSorted())
                {
                    MessageBox.Show("Congratulations!!! You have solved the puzzle.", "Puzzle Solved",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnReset.PerformClick();
                }
            }
        }

        /// <summary>
        /// Removes the controls from pnlGrid
        /// Then calls AddGrid() to add new image or grid size
        /// </summary>
        private void ClearAndAddNew()
        {
            foreach (PictureBox pic in picTiles)
            {
                if (pnlGrid.Controls.Contains(pic))
                {
                    pnlGrid.Controls.Remove(pic);
                    pic.Dispose();
                }
            }
            pnlGrid.Refresh();
            AddGrid();
        }

        /// <summary>
        /// Adds new picture box controls to pnl grid
        /// in a n x n grid with the picture selected
        /// </summary>
        private void AddGrid()
        {
            picTiles = new List<PictureBox>();
            int width = pnlGrid.Width / gridSize;
            int height = pnlGrid.Height / gridSize;
            int x;
            int y;
            int count = 0;

            for (int i = 0; i < gridSize; i++)
            {
                y = height * i;
                for (int j = 0; j < gridSize; j++)
                {
                    PictureBox picBox = new PictureBox();
                    x = width * j;
                    picBox.Width = width;
                    picBox.Height = height;
                    picBox.BorderStyle = BorderStyle.FixedSingle;
                    picBox.BackColor = Color.Black;
                    picBox.Left = x;
                    picBox.Top = y;
                    picBox.Name = count.ToString();
                    picBox.Click += new EventHandler(PicTiles_Click);
                    picTiles.Add(picBox);
                    picTiles[count].Image = gameTiles.Tiles.Tiles[count].TileImage;
                    pnlGrid.Controls.Add(picTiles[picTiles.Count - 1]);
                    count++;
                }
            }
        }


    }
}
