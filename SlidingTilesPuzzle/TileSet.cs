namespace SlidingTilesPuzzle
{
    public class TileSet
    {
        public List<Tile> Tiles { get; }
        public string TileSetName { get; set; }

        public TileSet(string name)
        {
            this.Tiles = new List<Tile>();
            this.TileSetName = name;
        }

        /// <summary>
        /// Adds a tile to the end of a tile set
        /// </summary>
        /// <param name="tile"></param>
        public void Add(Tile tile)
        {
            this.Tiles.Add(tile);
        }

        /// <summary>
        /// Return a tile from the set at position (position 0 indexed based)
        /// </summary>
        /// <param name="position"></param>
        /// <returns>
        /// Returns null if the position is not valid
        /// </returns>
        public Tile GetTile(int position)
        {
            if (position < Tiles.Count)
            {
                return this.Tiles[position];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Returns the tile image of tile at position (position 0 index based) : null otherwise
        /// </summary>
        /// <param name="postition"></param>
        /// <returns></returns>
        public Image? GetTileImage(int postition)
        {
            return GetTile(postition).TileImage;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="position1"></param>
        /// <param name="position2"></param>
        public void SwapTile(int position1, int position2)
        {
            (this.Tiles[position1], this.Tiles[position2]) = (this.Tiles[position2], this.Tiles[position1]);
        }

        /// <summary>
        /// Shuffles the tile set
        /// </summary>
        public void shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < Tiles.Count; i++)
            {
                int swapIndex = random.Next(Tiles.Count);
                (Tiles[i], Tiles[swapIndex]) = (Tiles[swapIndex], Tiles[i]);
            }
        }

        /// <summary>
        /// Sorts the tiles in acsending order of tile value using insertion sort
        /// </summary>
        public void Sort()
        {
            //Use simple insertion sort
            for (int i = 1; i < Tiles.Count; i++)
            {
                int j = i;
                while (j > 0)
                {
                    if (Tiles[j].CompareTo(Tiles[j -1]) < 0)
                    {
                        //swap
                        //(Tiles[j], Tiles[j - 1]) = (Tiles[j - 1], Tiles[j]);
                        SwapTile(j, j - 1);
                    }
                    j--;
                }
            }
        }

        /// <summary>
        /// check if the value of each tile in the tile set is in acsending order : Returns false otherwise
        /// </summary>
        /// <returns></returns>
        public bool IsSorted()
        {
            if (Tiles.Count == 1)
            {
                return true;
            }
            else if (Tiles.Count > 1)
            {
                for (int i = 1; i < Tiles.Count; i++)
                {
                    if (Tiles[i].CompareTo(Tiles[i - 1]) < 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
