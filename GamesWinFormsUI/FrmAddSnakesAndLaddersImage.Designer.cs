namespace GamesWinFormsUI
{
    partial class FrmAddSnakesAndLaddersImage
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
            PnlImage = new Panel();
            GrpAddImage = new GroupBox();
            LblPanelHeight = new Label();
            LblPanelWidth = new Label();
            lblHeight = new Label();
            lblWidth = new Label();
            TbrWidth = new TrackBar();
            TbrHeight = new TrackBar();
            BtnGetBoardImage = new Button();
            grpRowsAndColumns = new GroupBox();
            NudColumns = new NumericUpDown();
            NudRows = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            DlgOpen = new OpenFileDialog();
            GrpFirstTilePosition = new GroupBox();
            RdoRightSide = new RadioButton();
            RdoLeftSide = new RadioButton();
            GrpAddLadders = new GroupBox();
            BtnRemoveLadder = new Button();
            BtnAddLadder = new Button();
            TxtLadderTop = new CustomUserControls.PositiveIntegerTextBox();
            TxtLadderBase = new CustomUserControls.PositiveIntegerTextBox();
            LstLadders = new ListBox();
            label4 = new Label();
            label3 = new Label();
            GrpAddSnakes = new GroupBox();
            BtnRemoveSnake = new Button();
            btnAddSnake = new Button();
            TxtSnakeTail = new CustomUserControls.PositiveIntegerTextBox();
            TxtSnakeHead = new CustomUserControls.PositiveIntegerTextBox();
            LstSnakes = new ListBox();
            label5 = new Label();
            label6 = new Label();
            LstParameters = new ListBox();
            label7 = new Label();
            TxtBoardName = new TextBox();
            BtnSave = new Button();
            BtnExit = new Button();
            GrpAddImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TbrWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TbrHeight).BeginInit();
            grpRowsAndColumns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudColumns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudRows).BeginInit();
            GrpFirstTilePosition.SuspendLayout();
            GrpAddLadders.SuspendLayout();
            GrpAddSnakes.SuspendLayout();
            SuspendLayout();
            // 
            // PnlImage
            // 
            PnlImage.BackgroundImageLayout = ImageLayout.Stretch;
            PnlImage.BorderStyle = BorderStyle.FixedSingle;
            PnlImage.Location = new Point(472, 12);
            PnlImage.Name = "PnlImage";
            PnlImage.Size = new Size(700, 700);
            PnlImage.TabIndex = 0;
            // 
            // GrpAddImage
            // 
            GrpAddImage.BackColor = Color.PowderBlue;
            GrpAddImage.Controls.Add(LblPanelHeight);
            GrpAddImage.Controls.Add(LblPanelWidth);
            GrpAddImage.Controls.Add(lblHeight);
            GrpAddImage.Controls.Add(lblWidth);
            GrpAddImage.Controls.Add(TbrWidth);
            GrpAddImage.Controls.Add(TbrHeight);
            GrpAddImage.Controls.Add(BtnGetBoardImage);
            GrpAddImage.FlatStyle = FlatStyle.Popup;
            GrpAddImage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GrpAddImage.Location = new Point(12, 48);
            GrpAddImage.Name = "GrpAddImage";
            GrpAddImage.Size = new Size(454, 168);
            GrpAddImage.TabIndex = 1;
            GrpAddImage.TabStop = false;
            GrpAddImage.Text = "Select and Adjust Snakes and Ladder Image";
            // 
            // LblPanelHeight
            // 
            LblPanelHeight.AutoSize = true;
            LblPanelHeight.ForeColor = Color.Red;
            LblPanelHeight.Location = new Point(122, 121);
            LblPanelHeight.Name = "LblPanelHeight";
            LblPanelHeight.Size = new Size(0, 21);
            LblPanelHeight.TabIndex = 4;
            // 
            // LblPanelWidth
            // 
            LblPanelWidth.AutoSize = true;
            LblPanelWidth.ForeColor = Color.Red;
            LblPanelWidth.Location = new Point(122, 70);
            LblPanelWidth.Name = "LblPanelWidth";
            LblPanelWidth.Size = new Size(0, 21);
            LblPanelWidth.TabIndex = 4;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(6, 121);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(104, 21);
            lblHeight.TabIndex = 3;
            lblHeight.Text = "Adjust Height";
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(6, 70);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(100, 21);
            lblWidth.TabIndex = 2;
            lblWidth.Text = "Adjust Width";
            // 
            // TbrWidth
            // 
            TbrWidth.BackColor = SystemColors.ControlDark;
            TbrWidth.LargeChange = 10;
            TbrWidth.Location = new Point(179, 58);
            TbrWidth.Maximum = 700;
            TbrWidth.Minimum = 500;
            TbrWidth.Name = "TbrWidth";
            TbrWidth.Size = new Size(269, 45);
            TbrWidth.TabIndex = 1;
            TbrWidth.TickFrequency = 10;
            TbrWidth.Value = 700;
            TbrWidth.Scroll += TbrWidth_Scroll;
            // 
            // TbrHeight
            // 
            TbrHeight.BackColor = SystemColors.ControlDark;
            TbrHeight.LargeChange = 10;
            TbrHeight.Location = new Point(179, 109);
            TbrHeight.Maximum = 700;
            TbrHeight.Minimum = 500;
            TbrHeight.Name = "TbrHeight";
            TbrHeight.Size = new Size(269, 45);
            TbrHeight.TabIndex = 2;
            TbrHeight.TickFrequency = 10;
            TbrHeight.Value = 700;
            TbrHeight.Scroll += TbrHeight_Scroll;
            // 
            // BtnGetBoardImage
            // 
            BtnGetBoardImage.AutoSize = true;
            BtnGetBoardImage.Location = new Point(6, 28);
            BtnGetBoardImage.Name = "BtnGetBoardImage";
            BtnGetBoardImage.Size = new Size(163, 35);
            BtnGetBoardImage.TabIndex = 0;
            BtnGetBoardImage.Text = "Get Board Image";
            BtnGetBoardImage.UseVisualStyleBackColor = true;
            BtnGetBoardImage.Click += BtnGetBoardImage_Click;
            // 
            // grpRowsAndColumns
            // 
            grpRowsAndColumns.BackColor = Color.PowderBlue;
            grpRowsAndColumns.Controls.Add(NudColumns);
            grpRowsAndColumns.Controls.Add(NudRows);
            grpRowsAndColumns.Controls.Add(label2);
            grpRowsAndColumns.Controls.Add(label1);
            grpRowsAndColumns.FlatStyle = FlatStyle.Popup;
            grpRowsAndColumns.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpRowsAndColumns.Location = new Point(12, 222);
            grpRowsAndColumns.Name = "grpRowsAndColumns";
            grpRowsAndColumns.Size = new Size(292, 59);
            grpRowsAndColumns.TabIndex = 2;
            grpRowsAndColumns.TabStop = false;
            grpRowsAndColumns.Text = "Set the Number of Rows and Columns";
            // 
            // NudColumns
            // 
            NudColumns.Location = new Point(212, 25);
            NudColumns.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NudColumns.Name = "NudColumns";
            NudColumns.Size = new Size(59, 29);
            NudColumns.TabIndex = 1;
            NudColumns.TextAlign = HorizontalAlignment.Center;
            NudColumns.Value = new decimal(new int[] { 10, 0, 0, 0 });
            NudColumns.ValueChanged += NudColumns_ValueChanged;
            // 
            // NudRows
            // 
            NudRows.Location = new Point(60, 25);
            NudRows.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NudRows.Name = "NudRows";
            NudRows.Size = new Size(59, 29);
            NudRows.TabIndex = 1;
            NudRows.TextAlign = HorizontalAlignment.Center;
            NudRows.Value = new decimal(new int[] { 10, 0, 0, 0 });
            NudRows.ValueChanged += NudRows_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 29);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 0;
            label2.Text = "Columns";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 0;
            label1.Text = "Rows";
            // 
            // DlgOpen
            // 
            DlgOpen.Filter = "All Files(*.*)|*.*|Bitmaps(*.bmp)|*.bmp|PNG(*.png)|*.png|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif";
            DlgOpen.Title = "Open Image File";
            // 
            // GrpFirstTilePosition
            // 
            GrpFirstTilePosition.BackColor = Color.PowderBlue;
            GrpFirstTilePosition.Controls.Add(RdoRightSide);
            GrpFirstTilePosition.Controls.Add(RdoLeftSide);
            GrpFirstTilePosition.FlatStyle = FlatStyle.Popup;
            GrpFirstTilePosition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GrpFirstTilePosition.Location = new Point(12, 287);
            GrpFirstTilePosition.Name = "GrpFirstTilePosition";
            GrpFirstTilePosition.Size = new Size(319, 60);
            GrpFirstTilePosition.TabIndex = 3;
            GrpFirstTilePosition.TabStop = false;
            GrpFirstTilePosition.Text = "Which Side of the Board is the First Square";
            // 
            // RdoRightSide
            // 
            RdoRightSide.AutoSize = true;
            RdoRightSide.Location = new Point(66, 28);
            RdoRightSide.Name = "RdoRightSide";
            RdoRightSide.Size = new Size(65, 25);
            RdoRightSide.TabIndex = 1;
            RdoRightSide.Text = "Right";
            RdoRightSide.UseVisualStyleBackColor = true;
            RdoRightSide.Click += RdoTileOneSide_Click;
            // 
            // RdoLeftSide
            // 
            RdoLeftSide.AutoSize = true;
            RdoLeftSide.Checked = true;
            RdoLeftSide.Location = new Point(6, 28);
            RdoLeftSide.Name = "RdoLeftSide";
            RdoLeftSide.Size = new Size(54, 25);
            RdoLeftSide.TabIndex = 0;
            RdoLeftSide.TabStop = true;
            RdoLeftSide.Text = "Left";
            RdoLeftSide.UseVisualStyleBackColor = true;
            RdoLeftSide.Click += RdoTileOneSide_Click;
            // 
            // GrpAddLadders
            // 
            GrpAddLadders.BackColor = Color.PowderBlue;
            GrpAddLadders.Controls.Add(BtnRemoveLadder);
            GrpAddLadders.Controls.Add(BtnAddLadder);
            GrpAddLadders.Controls.Add(TxtLadderTop);
            GrpAddLadders.Controls.Add(TxtLadderBase);
            GrpAddLadders.Controls.Add(LstLadders);
            GrpAddLadders.Controls.Add(label4);
            GrpAddLadders.Controls.Add(label3);
            GrpAddLadders.FlatStyle = FlatStyle.Popup;
            GrpAddLadders.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GrpAddLadders.Location = new Point(12, 353);
            GrpAddLadders.Name = "GrpAddLadders";
            GrpAddLadders.Size = new Size(220, 213);
            GrpAddLadders.TabIndex = 4;
            GrpAddLadders.TabStop = false;
            GrpAddLadders.Text = "Add Ladders";
            // 
            // BtnRemoveLadder
            // 
            BtnRemoveLadder.AutoSize = true;
            BtnRemoveLadder.Location = new Point(125, 121);
            BtnRemoveLadder.Name = "BtnRemoveLadder";
            BtnRemoveLadder.Size = new Size(77, 31);
            BtnRemoveLadder.TabIndex = 3;
            BtnRemoveLadder.Text = "Remove";
            BtnRemoveLadder.UseVisualStyleBackColor = true;
            BtnRemoveLadder.Click += BtnRemoveLadder_Click;
            // 
            // BtnAddLadder
            // 
            BtnAddLadder.AutoSize = true;
            BtnAddLadder.Location = new Point(154, 48);
            BtnAddLadder.Name = "BtnAddLadder";
            BtnAddLadder.Size = new Size(60, 31);
            BtnAddLadder.TabIndex = 2;
            BtnAddLadder.Text = "Add";
            BtnAddLadder.UseVisualStyleBackColor = true;
            BtnAddLadder.Click += BtnAddLadder_Click;
            // 
            // TxtLadderTop
            // 
            TxtLadderTop.Location = new Point(85, 50);
            TxtLadderTop.Name = "TxtLadderTop";
            TxtLadderTop.Size = new Size(63, 29);
            TxtLadderTop.TabIndex = 1;
            TxtLadderTop.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtLadderBase
            // 
            TxtLadderBase.Location = new Point(6, 50);
            TxtLadderBase.Name = "TxtLadderBase";
            TxtLadderBase.Size = new Size(63, 29);
            TxtLadderBase.TabIndex = 0;
            TxtLadderBase.TextAlign = HorizontalAlignment.Center;
            // 
            // LstLadders
            // 
            LstLadders.FormattingEnabled = true;
            LstLadders.ItemHeight = 21;
            LstLadders.Location = new Point(6, 85);
            LstLadders.Name = "LstLadders";
            LstLadders.Size = new Size(113, 109);
            LstLadders.TabIndex = 3;
            LstLadders.SelectedIndexChanged += LstLadders_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 25);
            label4.Name = "label4";
            label4.Size = new Size(34, 21);
            label4.TabIndex = 1;
            label4.Text = "Top";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 25);
            label3.Name = "label3";
            label3.Size = new Size(42, 21);
            label3.TabIndex = 0;
            label3.Text = "Base";
            // 
            // GrpAddSnakes
            // 
            GrpAddSnakes.BackColor = Color.PowderBlue;
            GrpAddSnakes.Controls.Add(BtnRemoveSnake);
            GrpAddSnakes.Controls.Add(btnAddSnake);
            GrpAddSnakes.Controls.Add(TxtSnakeTail);
            GrpAddSnakes.Controls.Add(TxtSnakeHead);
            GrpAddSnakes.Controls.Add(LstSnakes);
            GrpAddSnakes.Controls.Add(label5);
            GrpAddSnakes.Controls.Add(label6);
            GrpAddSnakes.FlatStyle = FlatStyle.Popup;
            GrpAddSnakes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GrpAddSnakes.Location = new Point(246, 352);
            GrpAddSnakes.Name = "GrpAddSnakes";
            GrpAddSnakes.Size = new Size(220, 213);
            GrpAddSnakes.TabIndex = 5;
            GrpAddSnakes.TabStop = false;
            GrpAddSnakes.Text = "Add Snakes";
            // 
            // BtnRemoveSnake
            // 
            BtnRemoveSnake.AutoSize = true;
            BtnRemoveSnake.Location = new Point(125, 122);
            BtnRemoveSnake.Name = "BtnRemoveSnake";
            BtnRemoveSnake.Size = new Size(77, 31);
            BtnRemoveSnake.TabIndex = 3;
            BtnRemoveSnake.Text = "Remove";
            BtnRemoveSnake.UseVisualStyleBackColor = true;
            BtnRemoveSnake.Click += BtnRemoveSnake_Click;
            // 
            // btnAddSnake
            // 
            btnAddSnake.AutoSize = true;
            btnAddSnake.Location = new Point(154, 48);
            btnAddSnake.Name = "btnAddSnake";
            btnAddSnake.Size = new Size(60, 31);
            btnAddSnake.TabIndex = 2;
            btnAddSnake.Text = "Add";
            btnAddSnake.UseVisualStyleBackColor = true;
            btnAddSnake.Click += btnAddSnake_Click;
            // 
            // TxtSnakeTail
            // 
            TxtSnakeTail.Location = new Point(85, 50);
            TxtSnakeTail.Name = "TxtSnakeTail";
            TxtSnakeTail.Size = new Size(63, 29);
            TxtSnakeTail.TabIndex = 1;
            TxtSnakeTail.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtSnakeHead
            // 
            TxtSnakeHead.Location = new Point(6, 50);
            TxtSnakeHead.Name = "TxtSnakeHead";
            TxtSnakeHead.Size = new Size(63, 29);
            TxtSnakeHead.TabIndex = 0;
            TxtSnakeHead.TextAlign = HorizontalAlignment.Center;
            // 
            // LstSnakes
            // 
            LstSnakes.FormattingEnabled = true;
            LstSnakes.ItemHeight = 21;
            LstSnakes.Location = new Point(6, 85);
            LstSnakes.Name = "LstSnakes";
            LstSnakes.Size = new Size(113, 109);
            LstSnakes.TabIndex = 3;
            LstSnakes.SelectedIndexChanged += LstSnakes_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(99, 25);
            label5.Name = "label5";
            label5.Size = new Size(32, 21);
            label5.TabIndex = 1;
            label5.Text = "Tail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 25);
            label6.Name = "label6";
            label6.Size = new Size(46, 21);
            label6.TabIndex = 0;
            label6.Text = "Head";
            // 
            // LstParameters
            // 
            LstParameters.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LstParameters.FormattingEnabled = true;
            LstParameters.HorizontalScrollbar = true;
            LstParameters.ItemHeight = 17;
            LstParameters.Location = new Point(15, 572);
            LstParameters.Name = "LstParameters";
            LstParameters.Size = new Size(217, 140);
            LstParameters.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 12);
            label7.Name = "label7";
            label7.Size = new Size(180, 21);
            label7.TabIndex = 4;
            label7.Text = "Give your Board a Name";
            // 
            // TxtBoardName
            // 
            TxtBoardName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBoardName.Location = new Point(208, 10);
            TxtBoardName.Name = "TxtBoardName";
            TxtBoardName.Size = new Size(252, 29);
            TxtBoardName.TabIndex = 0;
            TxtBoardName.Text = "MyBoard001";
            // 
            // BtnSave
            // 
            BtnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSave.Location = new Point(319, 612);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 30);
            BtnSave.TabIndex = 7;
            BtnSave.Text = "&Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnExit
            // 
            BtnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnExit.Location = new Point(319, 665);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(75, 30);
            BtnExit.TabIndex = 8;
            BtnExit.Text = "E&xit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // FrmAddSnakesAndLaddersImage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(BtnExit);
            Controls.Add(BtnSave);
            Controls.Add(TxtBoardName);
            Controls.Add(label7);
            Controls.Add(LstParameters);
            Controls.Add(GrpAddSnakes);
            Controls.Add(GrpAddLadders);
            Controls.Add(GrpFirstTilePosition);
            Controls.Add(grpRowsAndColumns);
            Controls.Add(GrpAddImage);
            Controls.Add(PnlImage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmAddSnakesAndLaddersImage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Snakes and Ladders Image";
            Load += FrmAddSnakesAndLaddersImage_Load;
            GrpAddImage.ResumeLayout(false);
            GrpAddImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TbrWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)TbrHeight).EndInit();
            grpRowsAndColumns.ResumeLayout(false);
            grpRowsAndColumns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudColumns).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudRows).EndInit();
            GrpFirstTilePosition.ResumeLayout(false);
            GrpFirstTilePosition.PerformLayout();
            GrpAddLadders.ResumeLayout(false);
            GrpAddLadders.PerformLayout();
            GrpAddSnakes.ResumeLayout(false);
            GrpAddSnakes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PnlImage;
        private GroupBox GrpAddImage;
        private Button BtnGetBoardImage;
        private TrackBar TbrHeight;
        private TrackBar TbrWidth;
        private Label lblHeight;
        private Label lblWidth;
        private GroupBox grpRowsAndColumns;
        private Label label1;
        private Label label2;
        private OpenFileDialog DlgOpen;
        private GroupBox GrpFirstTilePosition;
        private RadioButton RdoRightSide;
        private RadioButton RdoLeftSide;
        private Label LblPanelHeight;
        private Label LblPanelWidth;
        private GroupBox GrpAddLadders;
        private CustomUserControls.PositiveIntegerTextBox TxtLadderTop;
        private CustomUserControls.PositiveIntegerTextBox TxtLadderBase;
        private ListBox LstLadders;
        private Label label4;
        private Label label3;
        private Button BtnAddLadder;
        private GroupBox GrpAddSnakes;
        private Button btnAddSnake;
        private CustomUserControls.PositiveIntegerTextBox TxtSnakeTail;
        private CustomUserControls.PositiveIntegerTextBox TxtSnakeHead;
        private ListBox LstSnakes;
        private Label label5;
        private Label label6;
        private ListBox LstParameters;
        private Label label7;
        private TextBox TxtBoardName;
        private NumericUpDown NudRows;
        private NumericUpDown NudColumns;
        private Button BtnRemoveLadder;
        private Button BtnRemoveSnake;
        private Button BtnSave;
        private Button BtnExit;
    }
}