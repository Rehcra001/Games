using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VisualCardsLibray;

namespace BlackJackLibrary
{
    public class VisualBlackJackHand
    {
        public IList<List<VisualCard>> Hand { get; }
        //public int XBase { get; set; } 
        //public int YBase { get; set; }
        public string HandName { get; }
        public Image CardBackImage { get; set; }

        public VisualBlackJackHand(string name)
        {
            this.HandName = name;
            Hand = new List<List<VisualCard>>();
            Hand.Add(new List<VisualCard>());
        }

        public void AddNewHand()
        {
            Hand.Add(new List<VisualCard>());
        }

        /// <summary>
        /// Will split the first two cards dealt
        /// </summary>
        public void Split(int offset)
        {
            if (Hand[0].Count == 2 && Hand.Count == 1)
            {
                Hand.Add(new List<VisualCard>());
                Hand[1].Add(Hand[0][1]);
                Hand[0].RemoveAt(1);
            }
        }

    }
}
