using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackLibrary
{
    public class PlayerPot
    {
        //public Dictionary<int, int> Pot { get; set; }
        public int PotValue { get; private set; }

        //Each player has a pot of casino chips
        public PlayerPot (int amount = 0)
        {
            PotValue = amount;
        }


        public void AddToPot(int amount)
        {
            PotValue += amount;
        }

        public void RemoveFromPot(int amount)
        {
            if (PotValue >= amount)
            {
                PotValue -= amount;
            }
            else
            {
                MessageBox.Show($"Not enough of {amount} chips to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Clear()
        {
            PotValue = 0;
        }
    }
}
