namespace SnakesAndLadders
{
    public class BoardTile
    {
        public int X { get; set; } //Left position
        public int Y { get; set; } //Top position
        public int Width { get; set; }
        public int Height { get; set; }
        public int Position { get; set; } 

        public BoardTile(int x, int y, int width, int height, int position = 0)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Position = position;
        }
    }
}
