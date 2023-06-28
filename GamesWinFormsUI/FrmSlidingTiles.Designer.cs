namespace GamesWinFormsUI
{
    partial class frmSlidingTiles
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
            pnlGrid = new Panel();
            pnlImages = new Panel();
            picChoice5 = new PictureBox();
            picChoice4 = new PictureBox();
            picChoice3 = new PictureBox();
            picChoice2 = new PictureBox();
            picChoice1 = new PictureBox();
            picChoice0 = new PictureBox();
            nudGridSize = new NumericUpDown();
            btnStart = new Button();
            btnReset = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            chkSound = new CheckBox();
            pnlImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChoice5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChoice4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChoice3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChoice2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChoice1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChoice0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGridSize).BeginInit();
            SuspendLayout();
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.Gray;
            pnlGrid.BorderStyle = BorderStyle.FixedSingle;
            pnlGrid.Location = new Point(46, 112);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(300, 300);
            pnlGrid.TabIndex = 0;
            // 
            // pnlImages
            // 
            pnlImages.BorderStyle = BorderStyle.FixedSingle;
            pnlImages.Controls.Add(picChoice5);
            pnlImages.Controls.Add(picChoice4);
            pnlImages.Controls.Add(picChoice3);
            pnlImages.Controls.Add(picChoice2);
            pnlImages.Controls.Add(picChoice1);
            pnlImages.Controls.Add(picChoice0);
            pnlImages.Location = new Point(572, 34);
            pnlImages.Name = "pnlImages";
            pnlImages.Size = new Size(300, 450);
            pnlImages.TabIndex = 1;
            // 
            // picChoice5
            // 
            picChoice5.Image = Properties.Resources.ButterFly;
            picChoice5.Location = new Point(150, 300);
            picChoice5.Name = "picChoice5";
            picChoice5.Size = new Size(150, 150);
            picChoice5.SizeMode = PictureBoxSizeMode.StretchImage;
            picChoice5.TabIndex = 0;
            picChoice5.TabStop = false;
            picChoice5.Click += PicChoice_Click;
            // 
            // picChoice4
            // 
            picChoice4.Image = Properties.Resources.Blue_Sea;
            picChoice4.Location = new Point(0, 300);
            picChoice4.Name = "picChoice4";
            picChoice4.Size = new Size(150, 150);
            picChoice4.SizeMode = PictureBoxSizeMode.StretchImage;
            picChoice4.TabIndex = 0;
            picChoice4.TabStop = false;
            picChoice4.Click += PicChoice_Click;
            // 
            // picChoice3
            // 
            picChoice3.Image = Properties.Resources.Dart_Board_300_x_300;
            picChoice3.Location = new Point(150, 150);
            picChoice3.Name = "picChoice3";
            picChoice3.Size = new Size(150, 150);
            picChoice3.SizeMode = PictureBoxSizeMode.StretchImage;
            picChoice3.TabIndex = 0;
            picChoice3.TabStop = false;
            picChoice3.Click += PicChoice_Click;
            // 
            // picChoice2
            // 
            picChoice2.Image = Properties.Resources.Taj_Mahal_300_x_300;
            picChoice2.Location = new Point(0, 150);
            picChoice2.Name = "picChoice2";
            picChoice2.Size = new Size(150, 150);
            picChoice2.SizeMode = PictureBoxSizeMode.StretchImage;
            picChoice2.TabIndex = 0;
            picChoice2.TabStop = false;
            picChoice2.Click += PicChoice_Click;
            // 
            // picChoice1
            // 
            picChoice1.Image = Properties.Resources.Nuclear_300_x_300;
            picChoice1.Location = new Point(150, 0);
            picChoice1.Name = "picChoice1";
            picChoice1.Size = new Size(150, 150);
            picChoice1.SizeMode = PictureBoxSizeMode.StretchImage;
            picChoice1.TabIndex = 0;
            picChoice1.TabStop = false;
            picChoice1.Click += PicChoice_Click;
            // 
            // picChoice0
            // 
            picChoice0.Image = Properties.Resources.Field_with_tree_300_x_300;
            picChoice0.Location = new Point(0, 0);
            picChoice0.Name = "picChoice0";
            picChoice0.Size = new Size(150, 150);
            picChoice0.SizeMode = PictureBoxSizeMode.StretchImage;
            picChoice0.TabIndex = 0;
            picChoice0.TabStop = false;
            picChoice0.Click += PicChoice_Click;
            // 
            // nudGridSize
            // 
            nudGridSize.Location = new Point(379, 185);
            nudGridSize.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudGridSize.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nudGridSize.Name = "nudGridSize";
            nudGridSize.Size = new Size(75, 23);
            nudGridSize.TabIndex = 2;
            nudGridSize.TextAlign = HorizontalAlignment.Center;
            nudGridSize.Value = new decimal(new int[] { 3, 0, 0, 0 });
            nudGridSize.ValueChanged += NudGridSize_ValueChanged;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(379, 234);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 3;
            btnStart.Text = "&Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += BtnStart_Click;
            // 
            // btnReset
            // 
            btnReset.Enabled = false;
            btnReset.Location = new Point(379, 283);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 4;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += BtnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(379, 332);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += BtnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(252, 16);
            label1.Name = "label1";
            label1.Size = new Size(261, 37);
            label1.TabIndex = 6;
            label1.Text = "Sliding Tiles Puzzle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(379, 167);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 7;
            label2.Text = "Grid Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(572, 16);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 8;
            label3.Text = "Click on Image to Use";
            // 
            // chkSound
            // 
            chkSound.AutoSize = true;
            chkSound.Checked = true;
            chkSound.CheckState = CheckState.Checked;
            chkSound.Location = new Point(379, 379);
            chkSound.Name = "chkSound";
            chkSound.Size = new Size(79, 19);
            chkSound.TabIndex = 9;
            chkSound.Text = "Sound On";
            chkSound.UseVisualStyleBackColor = true;
            // 
            // frmSlidingTiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 498);
            Controls.Add(chkSound);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnStart);
            Controls.Add(nudGridSize);
            Controls.Add(pnlImages);
            Controls.Add(pnlGrid);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmSlidingTiles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sliding Tiles Game";
            Load += FrmSlidingTiles_Load;
            pnlImages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picChoice5).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChoice4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChoice3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChoice2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChoice1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChoice0).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGridSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlGrid;
        private Panel pnlImages;
        private PictureBox picChoice5;
        private PictureBox picChoice4;
        private PictureBox picChoice3;
        private PictureBox picChoice2;
        private PictureBox picChoice1;
        private PictureBox picChoice0;
        private NumericUpDown nudGridSize;
        private Button btnStart;
        private Button btnReset;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox chkSound;
    }
}