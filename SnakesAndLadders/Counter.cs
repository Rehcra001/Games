using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakesAndLadders
{
    public partial class Counter : Button
    {
        //Counter represents a players piece on the board
        public int XOffset { get; set; } //x offset from Left of counter
        public int YOffset { get; set; } //y offset from Top of counter
        public int BoardPosition { get; set; } //Keeps track of it's board position

        public Counter(int width, int height, int left, int top, int xOffset, int yOffset, Color color, string text)
        {
            Width = width;
            Height = height;
            XOffset = xOffset;
            YOffset = yOffset;
            Left = left + XOffset;
            Top = top + YOffset;
            BackColor = color;
            Text = text;
        }

        public void CounterMove(int left, int top)
        {
            Left = left + XOffset;
            Top = top + YOffset;
        }
    }
}
