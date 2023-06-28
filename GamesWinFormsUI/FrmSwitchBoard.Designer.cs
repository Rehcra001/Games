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
            rdoSlidingTiles = new RadioButton();
            label1 = new Label();
            btnExit = new Button();
            grpGames.SuspendLayout();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(281, 147);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(75, 23);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "&Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += BtnPlay_Click;
            // 
            // grpGames
            // 
            grpGames.Controls.Add(rdoSlidingTiles);
            grpGames.Location = new Point(37, 109);
            grpGames.Name = "grpGames";
            grpGames.Size = new Size(200, 185);
            grpGames.TabIndex = 1;
            grpGames.TabStop = false;
            grpGames.Text = "Games";
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
            label1.Location = new Point(97, 35);
            label1.Name = "label1";
            label1.Size = new Size(240, 37);
            label1.TabIndex = 2;
            label1.Text = "Games Collection";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(281, 234);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += BtnExit_Click;
            // 
            // frmSwitchBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 372);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(grpGames);
            Controls.Add(btnPlay);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmSwitchBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Games Switch Board";
            grpGames.ResumeLayout(false);
            grpGames.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlay;
        private GroupBox grpGames;
        private Label label1;
        private Button btnExit;
        private RadioButton rdoSlidingTiles;
    }
}