namespace GamesWinFormsUI
{
    public partial class frmSwitchBoard : Form
    {
        public frmSwitchBoard()
        {
            InitializeComponent();
        }

        frmSlidingTiles frmSlidingTiles;
        frmSnakesAndLadders frmSnakesAndLadders;
        FrmAddSnakesAndLaddersImage frmAddSnakesAndLaddersImage;
        FrmBlackJack frmBlackJack;


        private void BtnPlay_Click(object sender, EventArgs e)
        {
            string game = "";
            foreach (RadioButton control in grpGames.Controls)
            {
                if (control.Checked)
                {
                    game = control.Text;
                }
            }

            switch (game)
            {
                case "Sliding Tiles":
                    frmSlidingTiles = new frmSlidingTiles();
                    this.Hide();
                    frmSlidingTiles.ShowDialog();
                    frmSlidingTiles.Close();
                    this.Show();
                    break;
                case "Snakes and Ladders":
                    frmSnakesAndLadders = new frmSnakesAndLadders();
                    this.Hide();
                    frmSnakesAndLadders.ShowDialog();
                    frmSnakesAndLadders.Close();
                    this.Show();
                    break;
                case "BlackJack":
                    frmBlackJack = new FrmBlackJack();
                    this.Hide();
                    frmBlackJack.ShowDialog();
                    frmBlackJack.Close();
                    this.Show();
                    break;
                default: break;
            }

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOpenUtility_Click(object sender, EventArgs e)
        {
            string utility = "";
            foreach (RadioButton control in grpUtilities.Controls)
            {
                if (control.Checked)
                {
                    utility = control.Text;
                }
            }

            switch (utility)
            {
                case "Add a Snake and Ladder Board":
                    frmAddSnakesAndLaddersImage = new FrmAddSnakesAndLaddersImage();
                    this.Hide();
                    frmAddSnakesAndLaddersImage.ShowDialog();
                    frmAddSnakesAndLaddersImage.Close();
                    this.Show();
                    break;
                default: break;
            }
        }
    }
}