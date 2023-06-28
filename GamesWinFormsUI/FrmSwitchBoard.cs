namespace GamesWinFormsUI
{
    public partial class frmSwitchBoard : Form
    {
        public frmSwitchBoard()
        {
            InitializeComponent();
        }

        frmSlidingTiles frmSlidingTiles;

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
                default: break;
            }

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}