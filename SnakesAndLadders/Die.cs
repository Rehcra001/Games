namespace SnakesAndLadders
{
    public class Die
    {
        private Random random = new Random();
        private int numSides;

        public Die (int numSides)
        {
            this.numSides = numSides;
        }

        public int GetValue()
        {
            return random.Next(numSides) + 1;
        }
    }
}
