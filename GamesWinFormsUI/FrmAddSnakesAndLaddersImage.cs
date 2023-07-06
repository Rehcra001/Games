using System.Diagnostics;
using System.IO;
//using System.Drawing.Imaging;
namespace GamesWinFormsUI
{
    public partial class FrmAddSnakesAndLaddersImage : Form
    {
        public FrmAddSnakesAndLaddersImage()
        {
            InitializeComponent();
        }

        Image image;
        string imageFilePath = "";
        int width;
        int height;
        int rows;
        int columns;
        bool tileOneOnLeftSide;

        private void FrmAddSnakesAndLaddersImage_Load(object sender, EventArgs e)
        {
            LblPanelWidth.Text = TbrWidth.Value.ToString();
            LblPanelHeight.Text = TbrHeight.Value.ToString();
            width = TbrWidth.Value;
            height = TbrHeight.Value;
            rows = Convert.ToInt32(NudRows.Value);
            columns = Convert.ToInt32(NudColumns.Value);
            tileOneOnLeftSide = true;

            UpdateParameters();
        }

        private void BtnGetBoardImage_Click(object sender, EventArgs e)
        {
            if (DlgOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int index = DlgOpen.FileName.LastIndexOf("\\");
                    string imageFileName = DlgOpen.FileName.Substring(index + 1);
                    imageFilePath = Application.StartupPath + "Snakes and Ladders Boards" + "\\" + imageFileName;
                    image = Image.FromFile(DlgOpen.FileName);
                    PnlImage.BackgroundImage = image;
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to open the Image File!", "File Open Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            UpdateParameters();
        }

        private void TbrWidth_Scroll(object sender, EventArgs e)
        {
            PnlImage.Width = TbrWidth.Value;
            LblPanelWidth.Text = TbrWidth.Value.ToString();
            width = TbrWidth.Value;
            UpdateParameters();
        }

        private void TbrHeight_Scroll(object sender, EventArgs e)
        {
            PnlImage.Height = TbrHeight.Value;
            LblPanelHeight.Text = TbrHeight.Value.ToString();
            height = TbrHeight.Value;
            UpdateParameters();
        }

        private void BtnAddLadder_Click(object sender, EventArgs e)
        {
            //Check that base and top have values
            //and that base is less than top
            //and top is less than rows * columns
            if (TxtLadderBase.Text == "")
            {
                MessageBox.Show("Base of ladder needs to be filled in!");
                TxtLadderBase.Focus();
            }
            else if (TxtLadderTop.Text == "")
            {
                MessageBox.Show("Top of ladder needs to be filled in!");
                TxtLadderTop.Focus();
            }
            else if (Convert.ToInt32(TxtLadderTop.Text) > rows * columns)
            {
                MessageBox.Show("Top of ladder needs to be less than the number of board squares!");
                TxtLadderTop.Text = "";
                TxtLadderTop.Focus();
            }
            else if (Convert.ToInt32(TxtLadderTop.Text) <= Convert.ToInt32(TxtLadderBase.Text))
            {
                MessageBox.Show("The top of the ladder needs to be greater than the base of the ladder");
                TxtLadderTop.Text = "";
                TxtLadderTop.Focus();
            }
            else
            {
                LstLadders.Items.Add(TxtLadderBase.Text + "," + TxtLadderTop.Text);
                TxtLadderBase.Text = "";
                TxtLadderTop.Text = "";
                TxtLadderBase.Focus();
                UpdateParameters();
            }
        }

        private void btnAddSnake_Click(object sender, EventArgs e)
        {
            //check that Head and Tail have values
            //and that head is greater than tail
            //and head is less than rows * columns
            if (TxtSnakeHead.Text == "")
            {
                MessageBox.Show("Head of snake needs to be filled in!");
                TxtSnakeHead.Focus();
            }
            else if (TxtSnakeTail.Text == "")
            {
                MessageBox.Show("Tail of snake needs to be filled in!");
                TxtSnakeTail.Focus();
            }
            else if (Convert.ToInt32(TxtSnakeHead.Text) > rows * columns)
            {
                MessageBox.Show("The snake head needs to be less than the number of board squares!");
                TxtSnakeHead.Text = "";
                TxtSnakeHead.Focus();
            }
            else if (Convert.ToInt32(TxtSnakeTail.Text) >= Convert.ToInt32(TxtSnakeHead.Text))
            {
                MessageBox.Show("The snake tail needs to be less than the head of the snake");
                TxtSnakeTail.Text = "";
                TxtSnakeTail.Focus();
            }
            else
            {
                LstSnakes.Items.Add(TxtSnakeHead.Text + "," + TxtSnakeTail.Text);
                TxtSnakeHead.Text = "";
                TxtSnakeTail.Text = "";
                TxtSnakeHead.Focus();
                UpdateParameters();
            }
        }

        private void NudRows_ValueChanged(object sender, EventArgs e)
        {
            rows = Convert.ToInt32(NudRows.Value);
            UpdateParameters();
        }

        private void NudColumns_ValueChanged(object sender, EventArgs e)
        {
            columns = Convert.ToInt32(NudColumns.Value);
            UpdateParameters();
        }

        private void RdoTileOneSide_Click(object sender, EventArgs e)
        {
            string name = ((RadioButton)sender).Text;
            if (name == "Left")
            {
                tileOneOnLeftSide = true;
            }
            else
            { tileOneOnLeftSide = false; }
            UpdateParameters();
        }

        private void BtnRemoveLadder_Click(object sender, EventArgs e)
        {
            if (LstLadders.SelectedItem != null)
            {
                LstLadders.Items.Remove(LstLadders.SelectedItem);
                UpdateParameters();
            }

        }

        private void BtnRemoveSnake_Click(object sender, EventArgs e)
        {
            if (LstSnakes.SelectedItem != null)
            {
                LstSnakes.Items.Remove(LstSnakes.SelectedItem);
                UpdateParameters();
            }
        }

        private void LstLadders_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnRemoveLadder.Focus();
        }

        private void LstSnakes_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnRemoveSnake.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //check parameters first
            if (ParametersCompleted())
            {
                //need to keep a list of saved boards and their paths to where they are saved


                string fileName = "\\" + TxtBoardName.Text.Trim() + ".txt";
                string path = Application.StartupPath + @"Snakes and Ladders Boards";

                //Check if the directory the text file will be saved in exists
                if (!Directory.Exists(path))
                {
                    //First time a board file is being saved
                    Directory.CreateDirectory(path);
                    //Add the image file to the directory will be reopened from here
                    try
                    {
                        image.Save(imageFilePath);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Problem saving the image file", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //Create the text to save
                    string file = CreateBoardTextFile();
                    //Add the parameters text file to the directory
                    try
                    {
                        StreamWriter outputFile = new StreamWriter(path + fileName);
                        outputFile.WriteLine(file);
                        outputFile.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Problem saving the board parameters file", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //Check if the filename to be saved exists
                    if (File.Exists(path + fileName))
                    {
                        DialogResult result = MessageBox.Show("File already exits!\r\nWould you like to overwrite this file?", "ERROR",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (result == DialogResult.Yes)
                        {
                            //Save the image file
                            image.Save(imageFilePath);
                            //Create the text to save
                            string file = CreateBoardTextFile();
                            try
                            {
                                StreamWriter outputFile = new StreamWriter(path + fileName);
                                outputFile.WriteLine(file);
                                outputFile.Close();
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Problem saving the board parameters file", "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        //Add the image file to the directory will be reopened from here
                        try
                        {
                            image.Save(imageFilePath);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Problem saving the image file", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        //Create the text to save
                        string file = CreateBoardTextFile();
                        //Add the parameters text file to the directory
                        try
                        {
                            StreamWriter outputFile = new StreamWriter(path + fileName);
                            outputFile.WriteLine(file);
                            outputFile.Close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Problem saving the board parameters file", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                return;
            }

        }

        private void UpdateParameters()
        {
            //Will build the parameters list to be saved
            //as a text file for the snakes and ladders
            //game to load
            LstParameters.Items.Clear();
            //Image file
            LstParameters.Items.Add("#Image file");
            LstParameters.Items.Add(imageFilePath);
            //Width and Height of panel
            LstParameters.Items.Add("#Width and Height");
            LstParameters.Items.Add(width.ToString() + "," + height.ToString());
            //Number of rows and columns
            LstParameters.Items.Add("#Number of rows and columns");
            LstParameters.Items.Add(rows.ToString() + "," + columns.ToString());
            //Side the first square is on (Left or Right)
            LstParameters.Items.Add("#First Tile on the Left");
            LstParameters.Items.Add(tileOneOnLeftSide);
            //Add Ladders
            LstParameters.Items.Add("#Ladders");
            if (LstLadders.Items.Count > 0)
            {
                for (int i = 0; i < LstLadders.Items.Count; i++)
                {
                    LstParameters.Items.Add(LstLadders.Items[i]);
                }
            }
            //Add Snakes
            LstParameters.Items.Add("#Snakes");
            if (LstSnakes.Items.Count > 0)
            {
                for (int i = 0; i < LstSnakes.Items.Count; i++)
                {
                    LstParameters.Items.Add(LstSnakes.Items[i]);
                }
            }
        }

        private bool ParametersCompleted()
        {
            if (image == null)
            {
                MessageBox.Show("An image needs to be loaded in order to save!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            for (int i = 0; i < LstParameters.Items.Count; i++)
            {
                if (LstParameters.Items[i].ToString() == "#Ladders")
                {
                    i++;
                    if (LstParameters.Items[i].ToString() == "#Snakes")
                    {
                        MessageBox.Show("There must be at least one Ladder entry!", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                if (LstParameters.Items[i].ToString() == "#Snakes")
                {
                    i++;
                    if (i == LstParameters.Items.Count)
                    {
                        MessageBox.Show("There must be at least one Snake entry!", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;

        }

        private string CreateBoardTextFile()
        {
            string file = "";
            for (int i = 0; i < LstParameters.Items.Count; i++)
            {
                if (i != LstParameters.Items.Count - 1)
                {
                    file += LstParameters.Items[i].ToString() + "\r\n";
                }
                else
                {
                    file += LstParameters.Items[i].ToString();
                }
            }
            return file;
        }
    }
}
