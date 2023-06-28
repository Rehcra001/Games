using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingTilesPuzzle
{
    public class SlidingTiles
    {
        public Image GameImage { get; set; }
        public TileSet Tiles { get; private set; }


        private int gridSize;

        public SlidingTiles (Image image, int gridSize, string setName = "Sliding Tiles Puzzle")
        {
            GameImage = image;
            Tiles = new TileSet(setName);
            this.gridSize = gridSize;
            PopulateTiles();
        }

        private void PopulateTiles()
        {
            int width = GameImage.Width / gridSize;
            int height = GameImage.Height / gridSize;
            int x;
            int y;
            int index = 0;
            //the first n - 1 tiles will have images
            //the last tile's image will be null
            try
            {
                for (int i = 0; i < gridSize; i++)
                {
                    y = height * i;
                    for (int j = 0; j < gridSize; j++)
                    {
                        x = width * j;
                        Bitmap source = new Bitmap(GameImage);
                        Rectangle rectangle = new Rectangle(x, y, width, height);
                        Image image = source.Clone(rectangle, source.PixelFormat);
                        Tile tile = new Tile(image, index);
                        Tiles.Add(tile);
                        source.Dispose();
                        index++;
                    }
                }
                //Last tile is null and has a large int value for sorting
                Tiles.Tiles[Tiles.Tiles.Count - 1].TileImage = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Problem creating tiles!!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Gets the index of a tile in the tile set based on the tile value;
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public int IndexOfTileValue(int val)
        {
            int index;

            for (index = 0; index < Tiles.Tiles.Count; index++)
            {
                if (Tiles.Tiles[index].Value == val)
                {
                    break;
                }
            }
            return index;
        }

        /// <summary>
        /// Checks if the tile with no image is reachable
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool IsReachable(int index)
        {
            //get the index of the tile with no image
            //this will always have the largest tile value in
            //the set
            //The only reachable idices are left, righ, up or down.

            int maxValueIndex = IndexOfTileValue(gridSize * gridSize - 1);
            int row = index / gridSize;
            int col = index % gridSize;

            //combination of reachable indices based on the index passed in
            //for a n x n grid

            //Top left corner
            if (row == 0 && col == 0)
            {
                //check right and down
                if (index + 1 == maxValueIndex)
                {
                    return true;
                }
                else if (index + gridSize == maxValueIndex)
                {
                    return true;
                }
            }
            //Bottom Left corner
            else if (row == gridSize -1 && col == 0)
            {
                //check right and up
                if (index + 1 == maxValueIndex)
                {
                    return true;
                }
                else if (index - gridSize == maxValueIndex)
                {
                    return true;
                }
            }
            //Top Right corner
            else if (row == 0 && col == gridSize - 1)
            {
                //check left and down
                if (index - 1 == maxValueIndex)
                {
                    return true;
                }
                else if (index + gridSize == maxValueIndex)
                {
                    return true;
                }
            }
            //Bottom Right corner
            else if (row == gridSize -1 && col == gridSize - 1)
            {
                //check left and up
                if (index - 1 == maxValueIndex)
                {
                    return true;
                }
                else if (index - gridSize == maxValueIndex)
                {
                    return true;
                }
            }
            //Top row
            else if (row == 0)
            {
                //check left, right and down
                if (index - 1 == maxValueIndex)
                {
                    return true;
                }
                else if (index + 1 == maxValueIndex)
                {
                    return true;
                }
                else if (index + gridSize == maxValueIndex)
                {
                    return true;
                }
            }
            //Left col
            else if (col == 0)
            {
                //check righ, up and down
                if (index + 1 == maxValueIndex)
                {
                    return true;
                }
                else if (index - gridSize == maxValueIndex)
                {
                    return true;
                }
                else if (index + gridSize == maxValueIndex)
                {
                    return true;
                }
            }
            //Right col
            else if (col == gridSize - 1)
            {
                //check left, up and down
                if (index - 1 == maxValueIndex)
                {
                    return true;
                }
                else if (index - gridSize == maxValueIndex)
                {
                    return true;
                }
                else if (index + gridSize == maxValueIndex)
                {
                    return true;
                }
            }
            //Bottom row
            else if (row == gridSize - 1)
            {
                //check left, right and up
                if (index - 1 == maxValueIndex)
                {
                    return true;
                }
                else if (index + 1 == maxValueIndex)
                {
                    return true;
                }
                else if (index - gridSize == maxValueIndex)
                {
                    return true;
                }
            }
            //check left, right, up, down
            else
            {
                if (index - 1 == maxValueIndex)
                {
                    return true;
                }
                else if (index + 1 == maxValueIndex)
                {
                    return true;
                }
                else if (index - gridSize == maxValueIndex)
                {
                    return true;
                }
                else if (index + gridSize == maxValueIndex)
                {
                    return true;
                }
            }


            return false;
        }

    }
}
