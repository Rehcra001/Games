namespace GamesWinFormsUI
{
    partial class frmSwitchBoard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPlay = new Button();
            grpGames = new GroupBox();
            rdoTest = new RadioButton();
            rdoSnakesAndLadders = new RadioButton();
            rdoSlidingTiles = new RadioButton();
            label1 = new Label();
            btnExit = new Button();
            grpUtilities = new GroupBox();
            rdoAddSnakeAndLadderBoardImage = new RadioButton();
            BtnOpenUtility = new Button();
            rdoBlackJack = new RadioButton();
            grpGames.SuspendLayout();
            grpUtilities.SuspendLayout();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(100, 300);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(75, 23);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "&Play Game";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += BtnPlay_Click;
            // 
            // grpGames
            // 
            grpGames.Controls.Add(rdoTest);
            grpGames.Controls.Add(rdoBlackJack);
            grpGames.Controls.Add(rdoSnakesAndLadders);
            grpGames.Controls.Add(rdoSlidingTiles);
            grpGames.Location = new Point(37, 95);
            grpGames.Name = "grpGames";
            grpGames.Size = new Size(200, 185);
            grpGames.TabIndex = 1;
            grpGames.TabStop = false;
            grpGames.Text = "Games";
            // 
            // rdoTest
            // 
            rdoTest.AutoSize = true;
            rdoTest.Location = new Point(27, 122);
            rdoTest.Name = "rdoTest";
            rdoTest.Size = new Size(45, 19);
            rdoTest.TabIndex = 1;
            rdoTest.TabStop = true;
            rdoTest.Text = "Test";
            rdoTest.UseVisualStyleBackColor = true;
            // 
            // rdoSnakesAndLadders
            // 
            rdoSnakesAndLadders.AutoSize = true;
            rdoSnakesAndLadders.Location = new Point(27, 60);
            rdoSnakesAndLadders.Name = "rdoSnakesAndLadders";
            rdoSnakesAndLadders.Size = new Size(128, 19);
            rdoSnakesAndLadders.TabIndex = 0;
            rdoSnakesAndLadders.Text = "Snakes and Ladders";
            rdoSnakesAndLadders.UseVisualStyleBackColor = true;
            // 
            // rdoSlidingTiles
            // 
            rdoSlidingTiles.AutoSize = true;
            rdoSlidingTiles.Checked = true;
            rdoSlidingTiles.Location = new Point(27, 35);
            rdoSlidingTiles.Name = "rdoSlidingTiles";
            rdoSlidingTiles.Size = new Size(87, 19);
            rdoSlidingTiles.TabIndex = 0;
            rdoSlidingTiles.TabStop = true;
            rdoSlidingTiles.Text = "Sliding Tiles";
            rdoSlidingTiles.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(149, 29);
            label1.Name = "label1";
            label1.Size = new Size(240, 37);
            label1.TabIndex = 2;
            label1.Text = "Games Collection";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(240, 337);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += BtnExit_Click;
            // 
            // grpUtilities
            // 
            grpUtilities.Controls.Add(rdoAddSnakeAndLadderBoardImage);
            grpUtilities.Location = new Point(276, 95);
            grpUtilities.Name = "grpUtilities";
            grpUtilities.Size = new Size(241, 185);
            grpUtilities.TabIndex = 1;
            grpUtilities.TabStop = false;
            grpUtilities.Text = "Utilities";
            // 
            // rdoAddSnakeAndLadderBoardImage
            // 
            rdoAddSnakeAndLadderBoardImage.AutoSize = true;
            rdoAddSnakeAndLadderBoardImage.Checked = true;
            rdoAddSnakeAndLadderBoardImage.Location = new Point(27, 35);
            rdoAddSnakeAndLadderBoardImage.Name = "rdoAddSnakeAndLadderBoardImage";
            rdoAddSnakeAndLadderBoardImage.Size = new Size(186, 19);
            rdoAddSnakeAndLadderBoardImage.TabIndex = 0;
            rdoAddSnakeAndLadderBoardImage.TabStop = true;
            rdoAddSnakeAndLadderBoardImage.Text = "Add a Snake and Ladder Board";
            rdoAddSnakeAndLadderBoardImage.UseVisualStyleBackColor = true;
            // 
            // BtnOpenUtility
            // 
            BtnOpenUtility.AutoSize = true;
            BtnOpenUtility.Location = new Point(356, 300);
            BtnOpenUtility.Name = "BtnOpenUtility";
            BtnOpenUtility.Size = new Size(80, 25);
            BtnOpenUtility.TabIndex = 4;
            BtnOpenUtility.Text = "Open Utility";
            BtnOpenUtility.UseVisualStyleBackColor = true;
            BtnOpenUtility.Click += BtnOpenUtility_Click;
            // 
            // rdoBlackJack
            // 
            rdoBlackJack.AutoSize = true;
            rdoBlackJack.Location = new Point(27, 85);
            rdoBlackJack.Name = "rdoBlackJack";
            rdoBlackJack.Size = new Size(75, 19);
            rdoBlackJack.TabIndex = 0;
            rdoBlackJack.Text = "BlackJack";
            rdoBlackJack.UseVisualStyleBackColor = true;
            // 
            // frmSwitchBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 372);
            Controls.Add(BtnOpenUtility);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(btnPlay);
            Controls.Add(grpUtilities);
            Controls.Add(grpGames);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmSwitchBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Games Switch Board";
            grpGames.ResumeLayout(false);
            grpGames.PerformLayout();
            grpUtilities.ResumeLayout(false);
            grpUtilities.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlay;
        private GroupBox grpGames;
        private Label label1;
        private Button btnExit;
        private RadioButton rdoSlidingTiles;
        private RadioButton rdoSnakesAndLadders;
        private GroupBox grpUtilities;
        private RadioButton rdoAddSnakeAndLadderBoardImage;
        private Button BtnOpenUtility;
        private RadioButton rdoTest;
        private RadioButton rdoBlackJack;
    }
}