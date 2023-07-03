namespace GamesWinFormsUI
{
    partial class frmSnakesAndLadders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            picDie1 = new PictureBox();
            picDie2 = new PictureBox();
            picDie3 = new PictureBox();
            picDie4 = new PictureBox();
            picDie5 = new PictureBox();
            picDie6 = new PictureBox();
            btnRollDie = new Button();
            picDieRoll = new PictureBox();
            timRollStart = new System.Windows.Forms.Timer(components);
            timRollStop = new System.Windows.Forms.Timer(components);
            grpNumberOfPlayers = new GroupBox();
            rdoPlayerFour = new RadioButton();
            rdoPlayerThree = new RadioButton();
            rdoPlayerTwo = new RadioButton();
            rdoPlayerOne = new RadioButton();
            timMovePlayer = new System.Windows.Forms.Timer(components);
            pnlGamePanel = new Panel();
            timLadder = new System.Windows.Forms.Timer(components);
            timSnake = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            btnStart = new Button();
            btnReset = new Button();
            btnHelp = new Button();
            btnExit = new Button();
            lblPlayer4 = new Label();
            lblPlayer3 = new Label();
            lblPlayer2 = new Label();
            lblPlayerFourSquare = new Label();
            lblPlayerThreeSquare = new Label();
            lblPlayerTwoSquare = new Label();
            lblPlayerOneSquare = new Label();
            lblNextPlayer = new Label();
            lblPlayer1 = new Label();
            lblGameName = new Label();
            ((System.ComponentModel.ISupportInitialize)picDie1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDie2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDie3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDie4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDie5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDie6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDieRoll).BeginInit();
            grpNumberOfPlayers.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // picDie1
            // 
            picDie1.Image = Properties.Resources.DICE1;
            picDie1.Location = new Point(12, 12);
            picDie1.Name = "picDie1";
            picDie1.Size = new Size(20, 20);
            picDie1.SizeMode = PictureBoxSizeMode.StretchImage;
            picDie1.TabIndex = 6;
            picDie1.TabStop = false;
            picDie1.Visible = false;
            // 
            // picDie2
            // 
            picDie2.Image = Properties.Resources.DICE2;
            picDie2.Location = new Point(38, 12);
            picDie2.Name = "picDie2";
            picDie2.Size = new Size(20, 20);
            picDie2.SizeMode = PictureBoxSizeMode.StretchImage;
            picDie2.TabIndex = 6;
            picDie2.TabStop = false;
            picDie2.Visible = false;
            // 
            // picDie3
            // 
            picDie3.Image = Properties.Resources.DICE3;
            picDie3.Location = new Point(64, 12);
            picDie3.Name = "picDie3";
            picDie3.Size = new Size(20, 20);
            picDie3.SizeMode = PictureBoxSizeMode.StretchImage;
            picDie3.TabIndex = 6;
            picDie3.TabStop = false;
            picDie3.Visible = false;
            // 
            // picDie4
            // 
            picDie4.Image = Properties.Resources.DICE4;
            picDie4.Location = new Point(90, 12);
            picDie4.Name = "picDie4";
            picDie4.Size = new Size(20, 20);
            picDie4.SizeMode = PictureBoxSizeMode.StretchImage;
            picDie4.TabIndex = 6;
            picDie4.TabStop = false;
            picDie4.Visible = false;
            // 
            // picDie5
            // 
            picDie5.Image = Properties.Resources.DICE5;
            picDie5.Location = new Point(116, 12);
            picDie5.Name = "picDie5";
            picDie5.Size = new Size(20, 20);
            picDie5.SizeMode = PictureBoxSizeMode.StretchImage;
            picDie5.TabIndex = 6;
            picDie5.TabStop = false;
            picDie5.Visible = false;
            // 
            // picDie6
            // 
            picDie6.Image = Properties.Resources.DICE6;
            picDie6.Location = new Point(142, 12);
            picDie6.Name = "picDie6";
            picDie6.Size = new Size(20, 20);
            picDie6.SizeMode = PictureBoxSizeMode.StretchImage;
            picDie6.TabIndex = 6;
            picDie6.TabStop = false;
            picDie6.Visible = false;
            // 
            // btnRollDie
            // 
            btnRollDie.AutoSize = true;
            btnRollDie.BackColor = Color.MistyRose;
            btnRollDie.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRollDie.Location = new Point(222, 346);
            btnRollDie.Name = "btnRollDie";
            btnRollDie.Size = new Size(97, 39);
            btnRollDie.TabIndex = 7;
            btnRollDie.Text = "Roll &Die";
            btnRollDie.UseVisualStyleBackColor = false;
            btnRollDie.Click += BtnRollDie_Click;
            // 
            // picDieRoll
            // 
            picDieRoll.BorderStyle = BorderStyle.FixedSingle;
            picDieRoll.Image = Properties.Resources.DICE1;
            picDieRoll.Location = new Point(148, 341);
            picDieRoll.Name = "picDieRoll";
            picDieRoll.Size = new Size(50, 50);
            picDieRoll.SizeMode = PictureBoxSizeMode.StretchImage;
            picDieRoll.TabIndex = 8;
            picDieRoll.TabStop = false;
            // 
            // timRollStart
            // 
            timRollStart.Tick += TimRollStart_Tick;
            // 
            // timRollStop
            // 
            timRollStop.Interval = 900;
            timRollStop.Tick += TimRollStop_Tick;
            // 
            // grpNumberOfPlayers
            // 
            grpNumberOfPlayers.BackColor = Color.Transparent;
            grpNumberOfPlayers.Controls.Add(rdoPlayerFour);
            grpNumberOfPlayers.Controls.Add(rdoPlayerThree);
            grpNumberOfPlayers.Controls.Add(rdoPlayerTwo);
            grpNumberOfPlayers.Controls.Add(rdoPlayerOne);
            grpNumberOfPlayers.FlatStyle = FlatStyle.Flat;
            grpNumberOfPlayers.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            grpNumberOfPlayers.ForeColor = Color.Black;
            grpNumberOfPlayers.Location = new Point(104, 189);
            grpNumberOfPlayers.Name = "grpNumberOfPlayers";
            grpNumberOfPlayers.Size = new Size(173, 142);
            grpNumberOfPlayers.TabIndex = 10;
            grpNumberOfPlayers.TabStop = false;
            grpNumberOfPlayers.Text = "Players";
            // 
            // rdoPlayerFour
            // 
            rdoPlayerFour.AutoSize = true;
            rdoPlayerFour.Location = new Point(17, 106);
            rdoPlayerFour.Name = "rdoPlayerFour";
            rdoPlayerFour.Size = new Size(140, 29);
            rdoPlayerFour.TabIndex = 1;
            rdoPlayerFour.Text = "Four Players";
            rdoPlayerFour.UseVisualStyleBackColor = true;
            rdoPlayerFour.Click += RdoPlayers_Click;
            // 
            // rdoPlayerThree
            // 
            rdoPlayerThree.AutoSize = true;
            rdoPlayerThree.Location = new Point(17, 79);
            rdoPlayerThree.Name = "rdoPlayerThree";
            rdoPlayerThree.Size = new Size(148, 29);
            rdoPlayerThree.TabIndex = 1;
            rdoPlayerThree.Text = "Three Players";
            rdoPlayerThree.UseVisualStyleBackColor = true;
            rdoPlayerThree.Click += RdoPlayers_Click;
            // 
            // rdoPlayerTwo
            // 
            rdoPlayerTwo.AutoSize = true;
            rdoPlayerTwo.Location = new Point(17, 52);
            rdoPlayerTwo.Name = "rdoPlayerTwo";
            rdoPlayerTwo.Size = new Size(135, 29);
            rdoPlayerTwo.TabIndex = 1;
            rdoPlayerTwo.Text = "Two Players";
            rdoPlayerTwo.UseVisualStyleBackColor = true;
            rdoPlayerTwo.Click += RdoPlayers_Click;
            // 
            // rdoPlayerOne
            // 
            rdoPlayerOne.AutoSize = true;
            rdoPlayerOne.Checked = true;
            rdoPlayerOne.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rdoPlayerOne.Location = new Point(17, 25);
            rdoPlayerOne.Name = "rdoPlayerOne";
            rdoPlayerOne.Size = new Size(145, 29);
            rdoPlayerOne.TabIndex = 0;
            rdoPlayerOne.TabStop = true;
            rdoPlayerOne.Text = "Single Player";
            rdoPlayerOne.UseVisualStyleBackColor = true;
            rdoPlayerOne.Click += RdoPlayers_Click;
            // 
            // timMovePlayer
            // 
            timMovePlayer.Interval = 200;
            timMovePlayer.Tick += TimMovePlayer_Tick;
            // 
            // pnlGamePanel
            // 
            pnlGamePanel.BackgroundImage = Properties.Resources.Snakes_And_Ladders_700_x_700;
            pnlGamePanel.BackgroundImageLayout = ImageLayout.Stretch;
            pnlGamePanel.BorderStyle = BorderStyle.FixedSingle;
            pnlGamePanel.Location = new Point(450, 30);
            pnlGamePanel.Name = "pnlGamePanel";
            pnlGamePanel.Size = new Size(700, 700);
            pnlGamePanel.TabIndex = 12;
            // 
            // timLadder
            // 
            timLadder.Interval = 30;
            timLadder.Tick += TimLadder_Tick;
            // 
            // timSnake
            // 
            timSnake.Interval = 30;
            timSnake.Tick += timSnake_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.ClipBoard;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnStart);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(btnHelp);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(lblPlayer4);
            panel1.Controls.Add(lblPlayer3);
            panel1.Controls.Add(lblPlayer2);
            panel1.Controls.Add(lblPlayerFourSquare);
            panel1.Controls.Add(lblPlayerThreeSquare);
            panel1.Controls.Add(lblPlayerTwoSquare);
            panel1.Controls.Add(lblPlayerOneSquare);
            panel1.Controls.Add(lblNextPlayer);
            panel1.Controls.Add(lblPlayer1);
            panel1.Controls.Add(lblGameName);
            panel1.Controls.Add(grpNumberOfPlayers);
            panel1.Controls.Add(picDieRoll);
            panel1.Controls.Add(btnRollDie);
            panel1.Location = new Point(12, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 700);
            panel1.TabIndex = 16;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.ForeColor = Color.Black;
            btnStart.Location = new Point(283, 203);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 29);
            btnStart.TabIndex = 21;
            btnStart.Text = "&Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += BtnStart_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(283, 234);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 29);
            btnReset.TabIndex = 21;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += BtnReset_Click;
            // 
            // btnHelp
            // 
            btnHelp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHelp.ForeColor = Color.Black;
            btnHelp.Location = new Point(283, 296);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(75, 29);
            btnHelp.TabIndex = 21;
            btnHelp.Text = "&Help";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += BtnHelp_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(283, 265);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 29);
            btnExit.TabIndex = 21;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblPlayer4
            // 
            lblPlayer4.AutoSize = true;
            lblPlayer4.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayer4.Location = new Point(111, 541);
            lblPlayer4.Name = "lblPlayer4";
            lblPlayer4.Size = new Size(193, 26);
            lblPlayer4.TabIndex = 20;
            lblPlayer4.Text = "Player 4 is on square";
            // 
            // lblPlayer3
            // 
            lblPlayer3.AutoSize = true;
            lblPlayer3.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayer3.Location = new Point(111, 515);
            lblPlayer3.Name = "lblPlayer3";
            lblPlayer3.Size = new Size(193, 26);
            lblPlayer3.TabIndex = 19;
            lblPlayer3.Text = "Player 3 is on square";
            // 
            // lblPlayer2
            // 
            lblPlayer2.AutoSize = true;
            lblPlayer2.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayer2.Location = new Point(111, 488);
            lblPlayer2.Name = "lblPlayer2";
            lblPlayer2.Size = new Size(193, 26);
            lblPlayer2.TabIndex = 18;
            lblPlayer2.Text = "Player 2 is on square";
            // 
            // lblPlayerFourSquare
            // 
            lblPlayerFourSquare.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayerFourSquare.ForeColor = Color.Red;
            lblPlayerFourSquare.Location = new Point(313, 542);
            lblPlayerFourSquare.Name = "lblPlayerFourSquare";
            lblPlayerFourSquare.Size = new Size(45, 26);
            lblPlayerFourSquare.TabIndex = 17;
            lblPlayerFourSquare.Text = "0";
            lblPlayerFourSquare.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlayerThreeSquare
            // 
            lblPlayerThreeSquare.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayerThreeSquare.ForeColor = Color.Red;
            lblPlayerThreeSquare.Location = new Point(313, 515);
            lblPlayerThreeSquare.Name = "lblPlayerThreeSquare";
            lblPlayerThreeSquare.Size = new Size(45, 26);
            lblPlayerThreeSquare.TabIndex = 17;
            lblPlayerThreeSquare.Text = "0";
            lblPlayerThreeSquare.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlayerTwoSquare
            // 
            lblPlayerTwoSquare.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayerTwoSquare.ForeColor = Color.Red;
            lblPlayerTwoSquare.Location = new Point(313, 488);
            lblPlayerTwoSquare.Name = "lblPlayerTwoSquare";
            lblPlayerTwoSquare.Size = new Size(45, 26);
            lblPlayerTwoSquare.TabIndex = 17;
            lblPlayerTwoSquare.Text = "0";
            lblPlayerTwoSquare.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlayerOneSquare
            // 
            lblPlayerOneSquare.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayerOneSquare.ForeColor = Color.Red;
            lblPlayerOneSquare.Location = new Point(313, 461);
            lblPlayerOneSquare.Name = "lblPlayerOneSquare";
            lblPlayerOneSquare.Size = new Size(45, 26);
            lblPlayerOneSquare.TabIndex = 17;
            lblPlayerOneSquare.Text = "0";
            lblPlayerOneSquare.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNextPlayer
            // 
            lblNextPlayer.AutoSize = true;
            lblNextPlayer.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblNextPlayer.ForeColor = Color.Red;
            lblNextPlayer.Location = new Point(111, 399);
            lblNextPlayer.Name = "lblNextPlayer";
            lblNextPlayer.Size = new Size(244, 33);
            lblNextPlayer.TabIndex = 17;
            lblNextPlayer.Text = "Player 1 to Roll Next";
            // 
            // lblPlayer1
            // 
            lblPlayer1.AutoSize = true;
            lblPlayer1.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayer1.Location = new Point(111, 461);
            lblPlayer1.Name = "lblPlayer1";
            lblPlayer1.Size = new Size(190, 26);
            lblPlayer1.TabIndex = 17;
            lblPlayer1.Text = "Player 1 is on square";
            // 
            // lblGameName
            // 
            lblGameName.AutoSize = true;
            lblGameName.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            lblGameName.ForeColor = Color.Red;
            lblGameName.Location = new Point(96, 137);
            lblGameName.Name = "lblGameName";
            lblGameName.Size = new Size(280, 38);
            lblGameName.TabIndex = 16;
            lblGameName.Text = "Snakes and Ladders";
            // 
            // frmSnakesAndLadders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WoodPanel2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 761);
            Controls.Add(pnlGamePanel);
            Controls.Add(picDie6);
            Controls.Add(picDie5);
            Controls.Add(picDie4);
            Controls.Add(picDie3);
            Controls.Add(picDie2);
            Controls.Add(picDie1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmSnakesAndLadders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Snakes And Ladders";
            Load += FrmSnakesAndLadders_Load;
            ((System.ComponentModel.ISupportInitialize)picDie1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDie2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDie3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDie4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDie5).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDie6).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDieRoll).EndInit();
            grpNumberOfPlayers.ResumeLayout(false);
            grpNumberOfPlayers.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox picDie1;
        private PictureBox picDie2;
        private PictureBox picDie3;
        private PictureBox picDie4;
        private PictureBox picDie5;
        private PictureBox picDie6;
        private Button btnRollDie;
        private PictureBox picDieRoll;
        private System.Windows.Forms.Timer timRollStart;
        private System.Windows.Forms.Timer timRollStop;
        private GroupBox grpNumberOfPlayers;
        private RadioButton rdoPlayerTwo;
        private RadioButton rdoPlayerOne;
        private System.Windows.Forms.Timer timMovePlayer;
        private RadioButton rdoPlayerFour;
        private RadioButton rdoPlayerThree;
        private Panel pnlGamePanel;
        private System.Windows.Forms.Timer timLadder;
        private System.Windows.Forms.Timer timSnake;
        private Panel panel1;
        private Label lblGameName;
        private Label lblPlayer4;
        private Label lblPlayer3;
        private Label lblPlayer2;
        private Label lblPlayer1;
        private Label lblPlayerOneSquare;
        private Label lblPlayerThreeSquare;
        private Label lblPlayerTwoSquare;
        private Label lblPlayerFourSquare;
        private Button btnExit;
        private Label lblNextPlayer;
        private Button btnStart;
        private Button btnReset;
        private Button btnHelp;
    }
}