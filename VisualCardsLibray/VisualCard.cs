using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace VisualCardsLibray
{
    public class VisualCard : PictureBox
    {
        public Image BackImage { get; private set; }
        public Image FrontImage { get; private set; }
        public int HomeX { get; set; } //The cards final position when moving
        public int HomeY { get; set; } //The cards final position when moving
        public string DealTo { get; set; }


        public VisualCard(int width, int height, int x, int y)
        {
            this.Width = width;
            this.Height = height;
            this.Left = x;
            this.Top = y;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public VisualCard(int width, int height, int x, int y, Image frontImage, Image backImage)
        {
            this.Width = width;
            this.Height = height;
            this.Left = x;
            this.Top = y;
            this.FrontImage = frontImage;
            this.BackImage = backImage;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            //ShowFrontImage();
            //this.Visible = true;
        }

        public void MoveCard(int deltaX, int deltaY)
        {
            this.Left += deltaX;
            this.Top += deltaY;
        }

        public void ShowFrontImage()
        {
            this.Image = FrontImage;
        }

        public void SetAndShowFrontImage(Image frontImage)
        {
            this.FrontImage = frontImage;
            this.Image = FrontImage;
        }

        public void ShowBackImage()
        {
            this.Image = BackImage;
        }

        public void SetAndShowBackImage(Image backImage)
        {
            this.BackImage = backImage;
            this.Image = BackImage;
        }

    }
}
