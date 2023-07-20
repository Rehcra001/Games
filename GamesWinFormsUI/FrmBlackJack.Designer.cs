namespace GamesWinFormsUI
{
    partial class FrmBlackJack
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
            BtnHit = new Button();
            BtnStay = new Button();
            BtnSplit = new Button();
            BtnDoubleDown = new Button();
            BtnDeal = new Button();
            BtnDiscard = new Button();
            BtnJoin0 = new Button();
            BtnJoin1 = new Button();
            BtnJoin3 = new Button();
            BtnJoin2 = new Button();
            PnlPlayer0 = new Panel();
            GrpPotBet0 = new GroupBox();
            TxtBetAmount0 = new CustomUserControls.PositiveIntegerTextBox();
            NudOnes0 = new NumericUpDown();
            NudTens0 = new NumericUpDown();
            NudHundreds0 = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            BtnConfirmBet0 = new Button();
            PnlPlayer1 = new Panel();
            GrpPotBet1 = new GroupBox();
            TxtBetAmount1 = new CustomUserControls.PositiveIntegerTextBox();
            NudOnes1 = new NumericUpDown();
            NudTens1 = new NumericUpDown();
            NudHundreds1 = new NumericUpDown();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            BtnConfirmBet1 = new Button();
            PnlPlayer2 = new Panel();
            GrpPotBet2 = new GroupBox();
            TxtBetAmount2 = new CustomUserControls.PositiveIntegerTextBox();
            NudOnes2 = new NumericUpDown();
            NudTens2 = new NumericUpDown();
            NudHundreds2 = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            BtnConfirmBet2 = new Button();
            PnlPlayer3 = new Panel();
            GrpPotBet3 = new GroupBox();
            TxtBetAmount3 = new CustomUserControls.PositiveIntegerTextBox();
            NudOnes3 = new NumericUpDown();
            NudTens3 = new NumericUpDown();
            NudHundreds3 = new NumericUpDown();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            BtnConfirmBet3 = new Button();
            PicDiscardPile = new PictureBox();
            PicDrawPile = new PictureBox();
            TimMoveDealCards = new System.Windows.Forms.Timer(components);
            TimMoveDealCard = new System.Windows.Forms.Timer(components);
            TimMoveHitCards = new System.Windows.Forms.Timer(components);
            TimMoveHitCard = new System.Windows.Forms.Timer(components);
            TimMoveDiscardCards = new System.Windows.Forms.Timer(components);
            timMoveDiscardCard = new System.Windows.Forms.Timer(components);
            TimMoveDealerTurnCards = new System.Windows.Forms.Timer(components);
            TimMoveDealerTurnCard = new System.Windows.Forms.Timer(components);
            LblPlayer0 = new Label();
            LblPlayer1 = new Label();
            LblPlayer2 = new Label();
            LblPlayer3 = new Label();
            PicPlayerPosition0 = new PictureBox();
            PicPlayerPosition1 = new PictureBox();
            PicPlayerPosition2 = new PictureBox();
            PicPlayerPosition3 = new PictureBox();
            PicDealerPosition = new PictureBox();
            LblPotValue0 = new Label();
            LblPotValue1 = new Label();
            LblPotValue2 = new Label();
            LblPotValue3 = new Label();
            label13 = new Label();
            label14 = new Label();
            TxtDealerHandState = new TextBox();
            BtnHouseRules = new Button();
            BtnExit = new Button();
            PnlPlayer0.SuspendLayout();
            GrpPotBet0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudOnes0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudTens0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudHundreds0).BeginInit();
            PnlPlayer1.SuspendLayout();
            GrpPotBet1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudOnes1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudTens1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudHundreds1).BeginInit();
            PnlPlayer2.SuspendLayout();
            GrpPotBet2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudOnes2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudTens2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudHundreds2).BeginInit();
            PnlPlayer3.SuspendLayout();
            GrpPotBet3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudOnes3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudTens3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudHundreds3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicDiscardPile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicDrawPile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicPlayerPosition0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicPlayerPosition1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicPlayerPosition2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicPlayerPosition3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicDealerPosition).BeginInit();
            SuspendLayout();
            // 
            // BtnHit
            // 
            BtnHit.AutoSize = true;
            BtnHit.BackColor = Color.LightCoral;
            BtnHit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnHit.Location = new Point(544, 332);
            BtnHit.Name = "BtnHit";
            BtnHit.Size = new Size(100, 31);
            BtnHit.TabIndex = 0;
            BtnHit.Text = "&Hit";
            BtnHit.UseVisualStyleBackColor = false;
            BtnHit.Click += BtnHit_Click;
            // 
            // BtnStay
            // 
            BtnStay.AutoSize = true;
            BtnStay.BackColor = Color.LightCoral;
            BtnStay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnStay.Location = new Point(544, 389);
            BtnStay.Name = "BtnStay";
            BtnStay.Size = new Size(100, 31);
            BtnStay.TabIndex = 1;
            BtnStay.Text = "&Stay";
            BtnStay.UseVisualStyleBackColor = false;
            BtnStay.Click += BtnStay_Click;
            // 
            // BtnSplit
            // 
            BtnSplit.AutoSize = true;
            BtnSplit.BackColor = Color.LightCoral;
            BtnSplit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSplit.Location = new Point(544, 446);
            BtnSplit.Name = "BtnSplit";
            BtnSplit.Size = new Size(100, 31);
            BtnSplit.TabIndex = 2;
            BtnSplit.Text = "S&plit";
            BtnSplit.UseVisualStyleBackColor = false;
            BtnSplit.Click += BtnSplit_Click;
            // 
            // BtnDoubleDown
            // 
            BtnDoubleDown.AutoSize = true;
            BtnDoubleDown.BackColor = Color.LightCoral;
            BtnDoubleDown.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDoubleDown.Location = new Point(532, 503);
            BtnDoubleDown.Name = "BtnDoubleDown";
            BtnDoubleDown.Size = new Size(125, 31);
            BtnDoubleDown.TabIndex = 3;
            BtnDoubleDown.Text = "D&ouble Down";
            BtnDoubleDown.UseVisualStyleBackColor = false;
            BtnDoubleDown.Click += BtnDoubleDown_Click;
            // 
            // BtnDeal
            // 
            BtnDeal.AutoSize = true;
            BtnDeal.BackColor = Color.BurlyWood;
            BtnDeal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDeal.Location = new Point(544, 551);
            BtnDeal.Name = "BtnDeal";
            BtnDeal.Size = new Size(100, 31);
            BtnDeal.TabIndex = 4;
            BtnDeal.Text = "&Deal";
            BtnDeal.UseVisualStyleBackColor = false;
            BtnDeal.Click += BtnDeal_Click;
            // 
            // BtnDiscard
            // 
            BtnDiscard.AutoSize = true;
            BtnDiscard.BackColor = Color.BurlyWood;
            BtnDiscard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDiscard.Location = new Point(544, 551);
            BtnDiscard.Name = "BtnDiscard";
            BtnDiscard.Size = new Size(100, 31);
            BtnDiscard.TabIndex = 5;
            BtnDiscard.Text = "D&iscard";
            BtnDiscard.UseVisualStyleBackColor = false;
            BtnDiscard.Click += BtnDiscard_Click;
            // 
            // BtnJoin0
            // 
            BtnJoin0.AutoSize = true;
            BtnJoin0.BackColor = Color.LightCoral;
            BtnJoin0.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnJoin0.Location = new Point(112, 420);
            BtnJoin0.Name = "BtnJoin0";
            BtnJoin0.Size = new Size(100, 31);
            BtnJoin0.TabIndex = 8;
            BtnJoin0.Text = "Join";
            BtnJoin0.UseVisualStyleBackColor = false;
            BtnJoin0.Click += BtnJoinGame_Clicked;
            // 
            // BtnJoin1
            // 
            BtnJoin1.AutoSize = true;
            BtnJoin1.BackColor = Color.LightCoral;
            BtnJoin1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnJoin1.Location = new Point(359, 558);
            BtnJoin1.Name = "BtnJoin1";
            BtnJoin1.Size = new Size(100, 31);
            BtnJoin1.TabIndex = 8;
            BtnJoin1.Text = "Join";
            BtnJoin1.UseVisualStyleBackColor = false;
            BtnJoin1.Click += BtnJoinGame_Clicked;
            // 
            // BtnJoin3
            // 
            BtnJoin3.AutoSize = true;
            BtnJoin3.BackColor = Color.LightCoral;
            BtnJoin3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnJoin3.Location = new Point(981, 428);
            BtnJoin3.Name = "BtnJoin3";
            BtnJoin3.Size = new Size(100, 31);
            BtnJoin3.TabIndex = 8;
            BtnJoin3.Text = "Join";
            BtnJoin3.UseVisualStyleBackColor = false;
            BtnJoin3.Click += BtnJoinGame_Clicked;
            // 
            // BtnJoin2
            // 
            BtnJoin2.AutoSize = true;
            BtnJoin2.BackColor = Color.LightCoral;
            BtnJoin2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnJoin2.Location = new Point(728, 558);
            BtnJoin2.Name = "BtnJoin2";
            BtnJoin2.Size = new Size(100, 31);
            BtnJoin2.TabIndex = 8;
            BtnJoin2.Text = "Join";
            BtnJoin2.UseVisualStyleBackColor = false;
            BtnJoin2.Click += BtnJoinGame_Clicked;
            // 
            // PnlPlayer0
            // 
            PnlPlayer0.BackColor = Color.Transparent;
            PnlPlayer0.Controls.Add(GrpPotBet0);
            PnlPlayer0.Location = new Point(62, 194);
            PnlPlayer0.Name = "PnlPlayer0";
            PnlPlayer0.Size = new Size(200, 189);
            PnlPlayer0.TabIndex = 11;
            // 
            // GrpPotBet0
            // 
            GrpPotBet0.BackColor = Color.Beige;
            GrpPotBet0.Controls.Add(TxtBetAmount0);
            GrpPotBet0.Controls.Add(NudOnes0);
            GrpPotBet0.Controls.Add(NudTens0);
            GrpPotBet0.Controls.Add(NudHundreds0);
            GrpPotBet0.Controls.Add(label4);
            GrpPotBet0.Controls.Add(label3);
            GrpPotBet0.Controls.Add(label2);
            GrpPotBet0.Controls.Add(BtnConfirmBet0);
            GrpPotBet0.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            GrpPotBet0.Location = new Point(3, 7);
            GrpPotBet0.Name = "GrpPotBet0";
            GrpPotBet0.Size = new Size(192, 182);
            GrpPotBet0.TabIndex = 0;
            GrpPotBet0.TabStop = false;
            GrpPotBet0.Text = "Bet";
            // 
            // TxtBetAmount0
            // 
            TxtBetAmount0.BackColor = Color.RosyBrown;
            TxtBetAmount0.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TxtBetAmount0.Location = new Point(119, 135);
            TxtBetAmount0.Name = "TxtBetAmount0";
            TxtBetAmount0.ReadOnly = true;
            TxtBetAmount0.Size = new Size(62, 29);
            TxtBetAmount0.TabIndex = 7;
            TxtBetAmount0.Text = "0";
            TxtBetAmount0.TextAlign = HorizontalAlignment.Center;
            // 
            // NudOnes0
            // 
            NudOnes0.BackColor = Color.RosyBrown;
            NudOnes0.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NudOnes0.Location = new Point(119, 100);
            NudOnes0.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            NudOnes0.Name = "NudOnes0";
            NudOnes0.Size = new Size(62, 29);
            NudOnes0.TabIndex = 6;
            NudOnes0.TextAlign = HorizontalAlignment.Center;
            NudOnes0.ValueChanged += NudBetAmount0_ValueChanged;
            // 
            // NudTens0
            // 
            NudTens0.BackColor = Color.RosyBrown;
            NudTens0.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NudTens0.Location = new Point(119, 64);
            NudTens0.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            NudTens0.Name = "NudTens0";
            NudTens0.Size = new Size(62, 29);
            NudTens0.TabIndex = 5;
            NudTens0.TextAlign = HorizontalAlignment.Center;
            NudTens0.ValueChanged += NudBetAmount0_ValueChanged;
            // 
            // NudHundreds0
            // 
            NudHundreds0.BackColor = Color.RosyBrown;
            NudHundreds0.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NudHundreds0.Location = new Point(119, 26);
            NudHundreds0.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            NudHundreds0.Name = "NudHundreds0";
            NudHundreds0.Size = new Size(62, 29);
            NudHundreds0.TabIndex = 4;
            NudHundreds0.TextAlign = HorizontalAlignment.Center;
            NudHundreds0.ValueChanged += NudBetAmount0_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(60, 104);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 3;
            label4.Text = "ONES";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(63, 68);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 2;
            label3.Text = "TENS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 30);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 1;
            label2.Text = "HUNDREDS";
            // 
            // BtnConfirmBet0
            // 
            BtnConfirmBet0.AutoSize = true;
            BtnConfirmBet0.BackColor = Color.LightCoral;
            BtnConfirmBet0.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold, GraphicsUnit.Point);
            BtnConfirmBet0.Location = new Point(2, 134);
            BtnConfirmBet0.Name = "BtnConfirmBet0";
            BtnConfirmBet0.Size = new Size(111, 31);
            BtnConfirmBet0.TabIndex = 3;
            BtnConfirmBet0.Text = "Confirm Bet";
            BtnConfirmBet0.UseVisualStyleBackColor = false;
            BtnConfirmBet0.Click += BtnConfirmBet_Clicked;
            // 
            // PnlPlayer1
            // 
            PnlPlayer1.BackColor = Color.Transparent;
            PnlPlayer1.Controls.Add(GrpPotBet1);
            PnlPlayer1.Location = new Point(309, 332);
            PnlPlayer1.Name = "PnlPlayer1";
            PnlPlayer1.Size = new Size(200, 189);
            PnlPlayer1.TabIndex = 11;
            // 
            // GrpPotBet1
            // 
            GrpPotBet1.BackColor = Color.Beige;
            GrpPotBet1.Controls.Add(TxtBetAmount1);
            GrpPotBet1.Controls.Add(NudOnes1);
            GrpPotBet1.Controls.Add(NudTens1);
            GrpPotBet1.Controls.Add(NudHundreds1);
            GrpPotBet1.Controls.Add(label1);
            GrpPotBet1.Controls.Add(label5);
            GrpPotBet1.Controls.Add(label6);
            GrpPotBet1.Controls.Add(BtnConfirmBet1);
            GrpPotBet1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            GrpPotBet1.Location = new Point(3, 7);
            GrpPotBet1.Name = "GrpPotBet1";
            GrpPotBet1.Size = new Size(192, 182);
            GrpPotBet1.TabIndex = 0;
            GrpPotBet1.TabStop = false;
            GrpPotBet1.Text = "Bet";
            // 
            // TxtBetAmount1
            // 
            TxtBetAmount1.BackColor = Color.RosyBrown;
            TxtBetAmount1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TxtBetAmount1.Location = new Point(119, 135);
            TxtBetAmount1.Name = "TxtBetAmount1";
            TxtBetAmount1.ReadOnly = true;
            TxtBetAmount1.Size = new Size(62, 29);
            TxtBetAmount1.TabIndex = 7;
            TxtBetAmount1.Text = "0";
            TxtBetAmount1.TextAlign = HorizontalAlignment.Center;
            // 
            // NudOnes1
            // 
            NudOnes1.BackColor = Color.RosyBrown;
            NudOnes1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NudOnes1.Location = new Point(119, 100);
            NudOnes1.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            NudOnes1.Name = "NudOnes1";
            NudOnes1.Size = new Size(62, 29);
            NudOnes1.TabIndex = 6;
            NudOnes1.TextAlign = HorizontalAlignment.Center;
            NudOnes1.ValueChanged += NudBetAmount1_ValueChanged;
            // 
            // NudTens1
            // 
            NudTens1.BackColor = Color.RosyBrown;
            NudTens1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NudTens1.Location = new Point(119, 64);
            NudTens1.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            NudTens1.Name = "NudTens1";
            NudTens1.Size = new Size(62, 29);
            NudTens1.TabIndex = 5;
            NudTens1.TextAlign = HorizontalAlignment.Center;
            NudTens1.ValueChanged += NudBetAmount1_ValueChanged;
            // 
            // NudHundreds1
            // 
            NudHundreds1.BackColor = Color.RosyBrown;
            NudHundreds1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NudHundreds1.Location = new Point(119, 26);
            NudHundreds1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            NudHundreds1.Name = "NudHundreds1";
            NudHundreds1.Size = new Size(62, 29);
            NudHundreds1.TabIndex = 4;
            NudHundreds1.TextAlign = HorizontalAlignment.Center;
            NudHundreds1.ValueChanged += NudBetAmount1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(60, 104);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 3;
            label1.Text = "ONES";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(63, 68);
            label5.Name = "label5";
            label5.Size = new Size(50, 21);
            label5.TabIndex = 2;
            label5.Text = "TENS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(14, 30);
            label6.Name = "label6";
            label6.Size = new Size(99, 21);
            label6.TabIndex = 1;
            label6.Text = "HUNDREDS";
            // 
            // BtnConfirmBet1
            // 
            BtnConfirmBet1.AutoSize = true;
            BtnConfirmBet1.BackColor = Color.LightCoral;
            BtnConfirmBet1.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold, GraphicsUnit.Point);
            BtnConfirmBet1.Location = new Point(2, 134);
            BtnConfirmBet1.Name = "BtnConfirmBet1";
            BtnConfirmBet1.Size = new Size(111, 31);
            BtnConfirmBet1.TabIndex = 3;
            BtnConfirmBet1.Text = "Confirm Bet";
            BtnConfirmBet1.UseVisualStyleBackColor = false;
            BtnConfirmBet1.Click += BtnConfirmBet_Clicked;
            // 
            // PnlPlayer2
            // 
            PnlPlayer2.BackColor = Color.Transparent;
            PnlPlayer2.Controls.Add(GrpPotBet2);
            PnlPlayer2.Location = new Point(678, 332);
            PnlPlayer2.Name = "PnlPlayer2";
            PnlPlayer2.Size = new Size(200, 189);
            PnlPlayer2.TabIndex = 11;
            // 
            // GrpPotBet2
            // 
            GrpPotBet2.BackColor = Color.Beige;
            GrpPotBet2.Controls.Add(TxtBetAmount2);
            GrpPotBet2.Controls.Add(NudOnes2);
            GrpPotBet2.Controls.Add(NudTens2);
            GrpPotBet2.Controls.Add(NudHundreds2);
            GrpPotBet2.Controls.Add(label7);
            GrpPotBet2.Controls.Add(label8);
            GrpPotBet2.Controls.Add(label9);
            GrpPotBet2.Controls.Add(BtnConfirmBet2);
            GrpPotBet2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            GrpPotBet2.Location = new Point(3, 7);
            GrpPotBet2.Name = "GrpPotBet2";
            GrpPotBet2.Size = new Size(192, 182);
            GrpPotBet2.TabIndex = 0;
            GrpPotBet2.TabStop = false;
            GrpPotBet2.Text = "Bet";
            // 
            // TxtBetAmount2
            // 
            TxtBetAmount2.BackColor = Color.RosyBrown;
            TxtBetAmount2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TxtBetAmount2.Location = new Point(119, 135);
            TxtBetAmount2.Name = "TxtBetAmount2";
            TxtBetAmount2.ReadOnly = true;
            TxtBetAmount2.Size = new Size(62, 29);
            TxtBetAmount2.TabIndex = 7;
            TxtBetAmount2.Text = "0";
            TxtBetAmount2.TextAlign = HorizontalAlignment.Center;
            // 
            // NudOnes2
            // 
            NudOnes2.BackColor = Color.RosyBrown;
            NudOnes2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NudOnes2.Location = new Point(119, 100);
            NudOnes2.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            NudOnes2.Name = "NudOnes2";
            NudOnes2.Size = new Size(62, 29);
            NudOnes2.TabIndex = 6;
            NudOnes2.TextAlign = HorizontalAlignment.Center;
            NudOnes2.ValueChanged += NudBetAmount2_ValueChanged;
            // 
            // NudTens2
            // 
            NudTens2.BackColor = Color.RosyBrown;
            NudTens2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NudTens2.Location = new Point(119, 64);
            NudTens2.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            NudTens2.Name = "NudTens2";
            NudTens2.Size = new Size(62, 29);
            NudTens2.TabIndex = 5;
            NudTens2.TextAlign = HorizontalAlignment.Center;
            NudTens2.ValueChanged += NudBetAmount2_ValueChanged;
            // 
            // NudHundreds2
            // 
            NudHundreds2.BackColor = Color.RosyBrown;
            NudHundreds2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NudHundreds2.Location = new Point(119, 26);
            NudHundreds2.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            NudHundreds2.Name = "NudHundreds2";
            NudHundreds2.Size = new Size(62, 29);
            NudHundreds2.TabIndex = 4;
            NudHundreds2.TextAlign = HorizontalAlignment.Center;
            NudHundreds2.ValueChanged += NudBetAmount2_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(60, 104);
            label7.Name = "label7";
            label7.Size = new Size(53, 21);
            label7.TabIndex = 3;
            label7.Text = "ONES";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(63, 68);
            label8.Name = "label8";
            label8.Size = new Size(50, 21);
            label8.TabIndex = 2;
            label8.Text = "TENS";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(14, 30);
            label9.Name = "label9";
            label9.Size = new Size(99, 21);
            label9.TabIndex = 1;
            label9.Text = "HUNDREDS";
            // 
            // BtnConfirmBet2
            // 
            BtnConfirmBet2.AutoSize = true;
            BtnConfirmBet2.BackColor = Color.LightCoral;
            BtnConfirmBet2.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold, GraphicsUnit.Point);
            BtnConfirmBet2.Location = new Point(2, 134);
            BtnConfirmBet2.Name = "BtnConfirmBet2";
            BtnConfirmBet2.Size = new Size(111, 31);
            BtnConfirmBet2.TabIndex = 3;
            BtnConfirmBet2.Text = "Confirm Bet";
            BtnConfirmBet2.UseVisualStyleBackColor = false;
            BtnConfirmBet2.Click += BtnConfirmBet_Clicked;
            // 
            // PnlPlayer3
            // 
            PnlPlayer3.BackColor = Color.Transparent;
            PnlPlayer3.Controls.Add(GrpPotBet3);
            PnlPlayer3.Location = new Point(931, 194);
            PnlPlayer3.Name = "PnlPlayer3";
            PnlPlayer3.Size = new Size(200, 189);
            PnlPlayer3.TabIndex = 11;
            // 
            // GrpPotBet3
            // 
            GrpPotBet3.BackColor = Color.Beige;
            GrpPotBet3.Controls.Add(TxtBetAmount3);
            GrpPotBet3.Controls.Add(NudOnes3);
            GrpPotBet3.Controls.Add(NudTens3);
            GrpPotBet3.Controls.Add(NudHundreds3);
            GrpPotBet3.Controls.Add(label10);
            GrpPotBet3.Controls.Add(label11);
            GrpPotBet3.Controls.Add(label12);
            GrpPotBet3.Controls.Add(BtnConfirmBet3);
            GrpPotBet3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            GrpPotBet3.Location = new Point(3, 7);
            GrpPotBet3.Name = "GrpPotBet3";
            GrpPotBet3.Size = new Size(192, 182);
            GrpPotBet3.TabIndex = 0;
            GrpPotBet3.TabStop = false;
            GrpPotBet3.Text = "Bet";
            // 
            // TxtBetAmount3
            // 
            TxtBetAmount3.BackColor = Color.RosyBrown;
            TxtBetAmount3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TxtBetAmount3.Location = new Point(119, 135);
            TxtBetAmount3.Name = "TxtBetAmount3";
            TxtBetAmount3.ReadOnly = true;
            TxtBetAmount3.Size = new Size(62, 29);
            TxtBetAmount3.TabIndex = 7;
            TxtBetAmount3.Text = "0";
            TxtBetAmount3.TextAlign = HorizontalAlignment.Center;
            // 
            // NudOnes3
            // 
            NudOnes3.BackColor = Color.RosyBrown;
            NudOnes3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NudOnes3.Location = new Point(119, 100);
            NudOnes3.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            NudOnes3.Name = "NudOnes3";
            NudOnes3.Size = new Size(62, 29);
            NudOnes3.TabIndex = 6;
            NudOnes3.TextAlign = HorizontalAlignment.Center;
            NudOnes3.ValueChanged += NudBetAmount3_ValueChanged;
            // 
            // NudTens3
            // 
            NudTens3.BackColor = Color.RosyBrown;
            NudTens3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NudTens3.Location = new Point(119, 64);
            NudTens3.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            NudTens3.Name = "NudTens3";
            NudTens3.Size = new Size(62, 29);
            NudTens3.TabIndex = 5;
            NudTens3.TextAlign = HorizontalAlignment.Center;
            NudTens3.ValueChanged += NudBetAmount3_ValueChanged;
            // 
            // NudHundreds3
            // 
            NudHundreds3.BackColor = Color.RosyBrown;
            NudHundreds3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NudHundreds3.Location = new Point(119, 26);
            NudHundreds3.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            NudHundreds3.Name = "NudHundreds3";
            NudHundreds3.Size = new Size(62, 29);
            NudHundreds3.TabIndex = 4;
            NudHundreds3.TextAlign = HorizontalAlignment.Center;
            NudHundreds3.ValueChanged += NudBetAmount3_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(60, 104);
            label10.Name = "label10";
            label10.Size = new Size(53, 21);
            label10.TabIndex = 3;
            label10.Text = "ONES";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(63, 68);
            label11.Name = "label11";
            label11.Size = new Size(50, 21);
            label11.TabIndex = 2;
            label11.Text = "TENS";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(14, 30);
            label12.Name = "label12";
            label12.Size = new Size(99, 21);
            label12.TabIndex = 1;
            label12.Text = "HUNDREDS";
            // 
            // BtnConfirmBet3
            // 
            BtnConfirmBet3.AutoSize = true;
            BtnConfirmBet3.BackColor = Color.LightCoral;
            BtnConfirmBet3.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold, GraphicsUnit.Point);
            BtnConfirmBet3.Location = new Point(2, 134);
            BtnConfirmBet3.Name = "BtnConfirmBet3";
            BtnConfirmBet3.Size = new Size(111, 31);
            BtnConfirmBet3.TabIndex = 3;
            BtnConfirmBet3.Text = "Confirm Bet";
            BtnConfirmBet3.UseVisualStyleBackColor = false;
            BtnConfirmBet3.Click += BtnConfirmBet_Clicked;
            // 
            // PicDiscardPile
            // 
            PicDiscardPile.BackgroundImageLayout = ImageLayout.None;
            PicDiscardPile.BorderStyle = BorderStyle.Fixed3D;
            PicDiscardPile.Location = new Point(367, 90);
            PicDiscardPile.Name = "PicDiscardPile";
            PicDiscardPile.Size = new Size(85, 115);
            PicDiscardPile.SizeMode = PictureBoxSizeMode.StretchImage;
            PicDiscardPile.TabIndex = 12;
            PicDiscardPile.TabStop = false;
            // 
            // PicDrawPile
            // 
            PicDrawPile.BackgroundImageLayout = ImageLayout.None;
            PicDrawPile.BorderStyle = BorderStyle.Fixed3D;
            PicDrawPile.Image = Properties.Resources.cardBack;
            PicDrawPile.Location = new Point(736, 90);
            PicDrawPile.Name = "PicDrawPile";
            PicDrawPile.Size = new Size(85, 115);
            PicDrawPile.SizeMode = PictureBoxSizeMode.StretchImage;
            PicDrawPile.TabIndex = 12;
            PicDrawPile.TabStop = false;
            // 
            // TimMoveDealCards
            // 
            TimMoveDealCards.Interval = 10;
            TimMoveDealCards.Tick += TimMoveDealCards_Tick;
            // 
            // TimMoveDealCard
            // 
            TimMoveDealCard.Interval = 5;
            TimMoveDealCard.Tick += TimMoveDealCard_Tick;
            // 
            // TimMoveHitCards
            // 
            TimMoveHitCards.Interval = 10;
            TimMoveHitCards.Tick += TimMoveHitCards_Tick;
            // 
            // TimMoveHitCard
            // 
            TimMoveHitCard.Interval = 5;
            TimMoveHitCard.Tick += TimMoveHitCard_Tick;
            // 
            // TimMoveDiscardCards
            // 
            TimMoveDiscardCards.Interval = 5;
            TimMoveDiscardCards.Tick += TimMoveDiscardCards_Tick;
            // 
            // timMoveDiscardCard
            // 
            timMoveDiscardCard.Interval = 5;
            timMoveDiscardCard.Tick += timMoveDiscardCard_Tick;
            // 
            // TimMoveDealerTurnCards
            // 
            TimMoveDealerTurnCards.Interval = 10;
            TimMoveDealerTurnCards.Tick += TimMoveDealerTurnCards_Tick;
            // 
            // TimMoveDealerTurnCard
            // 
            TimMoveDealerTurnCard.Interval = 5;
            TimMoveDealerTurnCard.Tick += TimMoveDealerTurnCard_Tick;
            // 
            // LblPlayer0
            // 
            LblPlayer0.AutoSize = true;
            LblPlayer0.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LblPlayer0.ForeColor = Color.Red;
            LblPlayer0.Location = new Point(92, 84);
            LblPlayer0.Name = "LblPlayer0";
            LblPlayer0.Size = new Size(141, 25);
            LblPlayer0.TabIndex = 14;
            LblPlayer0.Text = "Current Player";
            // 
            // LblPlayer1
            // 
            LblPlayer1.AutoSize = true;
            LblPlayer1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LblPlayer1.ForeColor = Color.Red;
            LblPlayer1.Location = new Point(340, 221);
            LblPlayer1.Name = "LblPlayer1";
            LblPlayer1.Size = new Size(141, 25);
            LblPlayer1.TabIndex = 14;
            LblPlayer1.Text = "Current Player";
            // 
            // LblPlayer2
            // 
            LblPlayer2.AutoSize = true;
            LblPlayer2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LblPlayer2.ForeColor = Color.Red;
            LblPlayer2.Location = new Point(707, 225);
            LblPlayer2.Name = "LblPlayer2";
            LblPlayer2.Size = new Size(141, 25);
            LblPlayer2.TabIndex = 14;
            LblPlayer2.Text = "Current Player";
            // 
            // LblPlayer3
            // 
            LblPlayer3.AutoSize = true;
            LblPlayer3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LblPlayer3.ForeColor = Color.Red;
            LblPlayer3.Location = new Point(958, 84);
            LblPlayer3.Name = "LblPlayer3";
            LblPlayer3.Size = new Size(141, 25);
            LblPlayer3.TabIndex = 14;
            LblPlayer3.Text = "Current Player";
            // 
            // PicPlayerPosition0
            // 
            PicPlayerPosition0.BackgroundImage = Properties.Resources.BlackJack_Logo;
            PicPlayerPosition0.BackgroundImageLayout = ImageLayout.Stretch;
            PicPlayerPosition0.Location = new Point(113, 272);
            PicPlayerPosition0.Name = "PicPlayerPosition0";
            PicPlayerPosition0.Size = new Size(98, 168);
            PicPlayerPosition0.TabIndex = 15;
            PicPlayerPosition0.TabStop = false;
            // 
            // PicPlayerPosition1
            // 
            PicPlayerPosition1.BackgroundImage = Properties.Resources.BlackJack_Logo;
            PicPlayerPosition1.BackgroundImageLayout = ImageLayout.Stretch;
            PicPlayerPosition1.Location = new Point(360, 409);
            PicPlayerPosition1.Name = "PicPlayerPosition1";
            PicPlayerPosition1.Size = new Size(98, 168);
            PicPlayerPosition1.TabIndex = 15;
            PicPlayerPosition1.TabStop = false;
            // 
            // PicPlayerPosition2
            // 
            PicPlayerPosition2.BackgroundImage = Properties.Resources.BlackJack_Logo;
            PicPlayerPosition2.BackgroundImageLayout = ImageLayout.Stretch;
            PicPlayerPosition2.Location = new Point(729, 410);
            PicPlayerPosition2.Name = "PicPlayerPosition2";
            PicPlayerPosition2.Size = new Size(98, 168);
            PicPlayerPosition2.TabIndex = 15;
            PicPlayerPosition2.TabStop = false;
            // 
            // PicPlayerPosition3
            // 
            PicPlayerPosition3.BackgroundImage = Properties.Resources.BlackJack_Logo;
            PicPlayerPosition3.BackgroundImageLayout = ImageLayout.Stretch;
            PicPlayerPosition3.Location = new Point(982, 280);
            PicPlayerPosition3.Name = "PicPlayerPosition3";
            PicPlayerPosition3.Size = new Size(98, 168);
            PicPlayerPosition3.TabIndex = 15;
            PicPlayerPosition3.TabStop = false;
            // 
            // PicDealerPosition
            // 
            PicDealerPosition.BackgroundImage = Properties.Resources.BlackJack_Logo;
            PicDealerPosition.BackgroundImageLayout = ImageLayout.Stretch;
            PicDealerPosition.Location = new Point(544, 68);
            PicDealerPosition.Name = "PicDealerPosition";
            PicDealerPosition.Size = new Size(98, 168);
            PicDealerPosition.TabIndex = 15;
            PicDealerPosition.TabStop = false;
            // 
            // LblPotValue0
            // 
            LblPotValue0.AutoSize = true;
            LblPotValue0.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LblPotValue0.ForeColor = Color.White;
            LblPotValue0.Location = new Point(65, 109);
            LblPotValue0.Name = "LblPotValue0";
            LblPotValue0.Size = new Size(101, 25);
            LblPotValue0.TabIndex = 14;
            LblPotValue0.Text = "Pot Value:";
            // 
            // LblPotValue1
            // 
            LblPotValue1.AutoSize = true;
            LblPotValue1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LblPotValue1.ForeColor = Color.White;
            LblPotValue1.Location = new Point(312, 246);
            LblPotValue1.Name = "LblPotValue1";
            LblPotValue1.Size = new Size(101, 25);
            LblPotValue1.TabIndex = 14;
            LblPotValue1.Text = "Pot Value:";
            // 
            // LblPotValue2
            // 
            LblPotValue2.AutoSize = true;
            LblPotValue2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LblPotValue2.ForeColor = Color.White;
            LblPotValue2.Location = new Point(678, 250);
            LblPotValue2.Name = "LblPotValue2";
            LblPotValue2.Size = new Size(101, 25);
            LblPotValue2.TabIndex = 14;
            LblPotValue2.Text = "Pot Value:";
            // 
            // LblPotValue3
            // 
            LblPotValue3.AutoSize = true;
            LblPotValue3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LblPotValue3.ForeColor = Color.White;
            LblPotValue3.Location = new Point(934, 109);
            LblPotValue3.Name = "LblPotValue3";
            LblPotValue3.Size = new Size(101, 25);
            LblPotValue3.TabIndex = 14;
            LblPotValue3.Text = "Pot Value:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(356, 62);
            label13.Name = "label13";
            label13.Size = new Size(107, 25);
            label13.TabIndex = 14;
            label13.Text = "Dicard Pile";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(730, 62);
            label14.Name = "label14";
            label14.Size = new Size(96, 25);
            label14.TabIndex = 14;
            label14.Text = "Draw Pile";
            // 
            // TxtDealerHandState
            // 
            TxtDealerHandState.BackColor = Color.Black;
            TxtDealerHandState.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TxtDealerHandState.ForeColor = Color.White;
            TxtDealerHandState.Location = new Point(431, 17);
            TxtDealerHandState.Name = "TxtDealerHandState";
            TxtDealerHandState.ReadOnly = true;
            TxtDealerHandState.Size = new Size(100, 29);
            TxtDealerHandState.TabIndex = 17;
            TxtDealerHandState.TabStop = false;
            TxtDealerHandState.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnHouseRules
            // 
            BtnHouseRules.AutoSize = true;
            BtnHouseRules.BackColor = Color.LightCoral;
            BtnHouseRules.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnHouseRules.Location = new Point(358, 618);
            BtnHouseRules.Name = "BtnHouseRules";
            BtnHouseRules.Size = new Size(113, 31);
            BtnHouseRules.TabIndex = 8;
            BtnHouseRules.Text = "House Rules";
            BtnHouseRules.UseVisualStyleBackColor = false;
            BtnHouseRules.Click += BtnHouseRules_Click;
            // 
            // BtnExit
            // 
            BtnExit.AutoSize = true;
            BtnExit.BackColor = Color.LightCoral;
            BtnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnExit.Location = new Point(730, 618);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(100, 31);
            BtnExit.TabIndex = 8;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // FrmBlackJack
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1184, 661);
            Controls.Add(TxtDealerHandState);
            Controls.Add(label14);
            Controls.Add(LblPlayer2);
            Controls.Add(label13);
            Controls.Add(LblPlayer1);
            Controls.Add(LblPlayer3);
            Controls.Add(LblPotValue3);
            Controls.Add(LblPotValue2);
            Controls.Add(LblPotValue1);
            Controls.Add(LblPotValue0);
            Controls.Add(LblPlayer0);
            Controls.Add(PicDrawPile);
            Controls.Add(PicDiscardPile);
            Controls.Add(PnlPlayer3);
            Controls.Add(PnlPlayer2);
            Controls.Add(PnlPlayer1);
            Controls.Add(BtnJoin3);
            Controls.Add(BtnJoin2);
            Controls.Add(BtnExit);
            Controls.Add(BtnHouseRules);
            Controls.Add(BtnJoin1);
            Controls.Add(BtnJoin0);
            Controls.Add(BtnDiscard);
            Controls.Add(BtnDeal);
            Controls.Add(BtnDoubleDown);
            Controls.Add(BtnSplit);
            Controls.Add(BtnStay);
            Controls.Add(BtnHit);
            Controls.Add(PnlPlayer0);
            Controls.Add(PicDealerPosition);
            Controls.Add(PicPlayerPosition0);
            Controls.Add(PicPlayerPosition1);
            Controls.Add(PicPlayerPosition2);
            Controls.Add(PicPlayerPosition3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(1200, 700);
            Name = "FrmBlackJack";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BlackJack";
            Load += FrmBlackJack_Load;
            Paint += FrmBlackJack_Paint;
            Resize += FrmBlackJack_Resize;
            PnlPlayer0.ResumeLayout(false);
            GrpPotBet0.ResumeLayout(false);
            GrpPotBet0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudOnes0).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudTens0).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudHundreds0).EndInit();
            PnlPlayer1.ResumeLayout(false);
            GrpPotBet1.ResumeLayout(false);
            GrpPotBet1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudOnes1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudTens1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudHundreds1).EndInit();
            PnlPlayer2.ResumeLayout(false);
            GrpPotBet2.ResumeLayout(false);
            GrpPotBet2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudOnes2).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudTens2).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudHundreds2).EndInit();
            PnlPlayer3.ResumeLayout(false);
            GrpPotBet3.ResumeLayout(false);
            GrpPotBet3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudOnes3).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudTens3).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudHundreds3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicDiscardPile).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicDrawPile).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicPlayerPosition0).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicPlayerPosition1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicPlayerPosition2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicPlayerPosition3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicDealerPosition).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnHit;
        private Button BtnStay;
        private Button BtnSplit;
        private Button BtnDoubleDown;
        private Button BtnDeal;
        private Button BtnDiscard;
        private Button BtnJoin0;
        private Button BtnJoin1;
        private Button BtnJoin3;
        private Button BtnJoin2;
        private Panel PnlPlayer0;
        private GroupBox GrpPotBet0;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown NudOnes0;
        private NumericUpDown NudTens0;
        private NumericUpDown NudHundreds0;
        private CustomUserControls.PositiveIntegerTextBox TxtBetAmount0;
        private Button BtnConfirmBet0;
        private Panel PnlPlayer1;
        private GroupBox GrpPotBet1;
        private CustomUserControls.PositiveIntegerTextBox TxtBetAmount1;
        private NumericUpDown NudOnes1;
        private NumericUpDown NudTens1;
        private NumericUpDown NudHundreds1;
        private Label label1;
        private Label label5;
        private Label label6;
        private Button BtnConfirmBet1;
        private Panel PnlPlayer2;
        private GroupBox GrpPotBet2;
        private CustomUserControls.PositiveIntegerTextBox TxtBetAmount2;
        private NumericUpDown NudOnes2;
        private NumericUpDown NudTens2;
        private NumericUpDown NudHundreds2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button BtnConfirmBet2;
        private Panel PnlPlayer3;
        private GroupBox GrpPotBet3;
        private CustomUserControls.PositiveIntegerTextBox TxtBetAmount3;
        private NumericUpDown NudOnes3;
        private NumericUpDown NudTens3;
        private NumericUpDown NudHundreds3;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button BtnConfirmBet3;
        private PictureBox PicDiscardPile;
        private PictureBox PicDrawPile;
        private System.Windows.Forms.Timer TimMoveDealCards;
        private System.Windows.Forms.Timer TimMoveDealCard;
        private System.Windows.Forms.Timer TimMoveHitCards;
        private System.Windows.Forms.Timer TimMoveHitCard;
        private System.Windows.Forms.Timer TimMoveDiscardCards;
        private System.Windows.Forms.Timer timMoveDiscardCard;
        private System.Windows.Forms.Timer TimMoveDealerTurnCards;
        private System.Windows.Forms.Timer TimMoveDealerTurnCard;
        private Label LblPlayer0;
        private Button button1;
        private Label LblPlayer1;
        private Button button2;
        private Label LblPlayer2;
        private Button button3;
        private Label LblPlayer3;
        private PictureBox PicPlayerPosition0;
        private PictureBox PicPlayerPosition1;
        private PictureBox PicPlayerPosition2;
        private PictureBox PicPlayerPosition3;
        private PictureBox PicDealerPosition;
        private Label LblPotValue0;
        private Label LblPotValue1;
        private Label LblPotValue2;
        private Label LblPotValue3;
        private Label label13;
        private Label label14;
        private TextBox TxtDealerHandState;
        private Button BtnHouseRules;
        private Button BtnExit;
    }
}