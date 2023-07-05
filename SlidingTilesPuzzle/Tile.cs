namespace SlidingTilesPuzzle
{
    public class Tile
    {
        public Image? TileImage { get; set; }
        public int Value { get; set; }

        public Tile(Image? tileImage, int value = 0)
        {
            this.TileImage = tileImage;
            this.Value = value;
        }

        /// <summary>
        /// Compares the values of this tile to another tile
        /// </summary>
        /// <param name="that"></param>
        /// <returns>
        /// -1 if the value of this is less than the other tile
        /// 0 if the value of this is the same as the other tile
        /// 1 if the value of this is less than the other tile
        /// </returns>
        public int CompareTo(Tile that)
        {
            if (this.Value < that.Value)
            {
                return -1;
            }
            else if (this.Value == that.Value)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
