﻿namespace Brave_Frontier_CG
{
    partial class FormBattleField
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBattleField));
            picIdle = new PictureBox();
            picAttack = new PictureBox();
            btnRock = new Button();
            btnPaper = new Button();
            btnSci = new Button();
            picEnemyChoice = new PictureBox();
            lblLives = new Label();
            lblResult = new Label();
            lblBotLives = new Label();
            lblPlayerLives = new Label();
            picPlayerChoice = new PictureBox();
            picCardHolder = new PictureBox();
            picBotIdle = new PictureBox();
            picBotAttack = new PictureBox();
            toolTipChoice = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)picIdle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAttack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEnemyChoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayerChoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCardHolder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBotIdle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBotAttack).BeginInit();
            SuspendLayout();
            // 
            // picIdle
            // 
            picIdle.BackColor = Color.Transparent;
            picIdle.BackgroundImageLayout = ImageLayout.Stretch;
            picIdle.Image = (Image)resources.GetObject("picIdle.Image");
            picIdle.Location = new Point(266, 100);
            picIdle.Name = "picIdle";
            picIdle.Size = new Size(117, 128);
            picIdle.TabIndex = 1;
            picIdle.TabStop = false;
            // 
            // picAttack
            // 
            picAttack.BackColor = Color.Transparent;
            picAttack.BackgroundImageLayout = ImageLayout.Stretch;
            picAttack.Image = (Image)resources.GetObject("picAttack.Image");
            picAttack.Location = new Point(135, 43);
            picAttack.Name = "picAttack";
            picAttack.Size = new Size(248, 197);
            picAttack.SizeMode = PictureBoxSizeMode.StretchImage;
            picAttack.TabIndex = 2;
            picAttack.TabStop = false;
            picAttack.Visible = false;
            // 
            // btnRock
            // 
            btnRock.BackColor = Color.Transparent;
            btnRock.BackgroundImage = Properties.Resources.SWORD;
            btnRock.BackgroundImageLayout = ImageLayout.Stretch;
            btnRock.FlatStyle = FlatStyle.Popup;
            btnRock.Location = new Point(22, 510);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(89, 111);
            btnRock.TabIndex = 3;
            btnRock.UseVisualStyleBackColor = false;
            btnRock.Click += btnRock_Click;
            // 
            // btnPaper
            // 
            btnPaper.BackColor = Color.Transparent;
            btnPaper.BackgroundImage = Properties.Resources.STAFF;
            btnPaper.BackgroundImageLayout = ImageLayout.Stretch;
            btnPaper.FlatStyle = FlatStyle.Popup;
            btnPaper.Location = new Point(154, 510);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(86, 111);
            btnPaper.TabIndex = 4;
            btnPaper.UseVisualStyleBackColor = false;
            btnPaper.Click += btnPaper_Click;
            // 
            // btnSci
            // 
            btnSci.BackColor = Color.Transparent;
            btnSci.BackgroundImage = Properties.Resources.BOW;
            btnSci.BackgroundImageLayout = ImageLayout.Stretch;
            btnSci.FlatStyle = FlatStyle.Popup;
            btnSci.Location = new Point(285, 510);
            btnSci.Name = "btnSci";
            btnSci.Size = new Size(87, 111);
            btnSci.TabIndex = 5;
            btnSci.UseVisualStyleBackColor = false;
            btnSci.Click += btnSci_Click;
            // 
            // picEnemyChoice
            // 
            picEnemyChoice.BackColor = Color.Transparent;
            picEnemyChoice.Location = new Point(12, 356);
            picEnemyChoice.Name = "picEnemyChoice";
            picEnemyChoice.Size = new Size(99, 120);
            picEnemyChoice.TabIndex = 6;
            picEnemyChoice.TabStop = false;
            // 
            // lblLives
            // 
            lblLives.AutoSize = true;
            lblLives.Location = new Point(95, 322);
            lblLives.Name = "lblLives";
            lblLives.Size = new Size(0, 20);
            lblLives.TabIndex = 7;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.Transparent;
            lblResult.ForeColor = SystemColors.ButtonHighlight;
            lblResult.Location = new Point(95, 315);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(195, 27);
            lblResult.TabIndex = 8;
            lblResult.Text = "You won";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBotLives
            // 
            lblBotLives.AutoSize = true;
            lblBotLives.BackColor = Color.Transparent;
            lblBotLives.ForeColor = SystemColors.Control;
            lblBotLives.Location = new Point(12, 9);
            lblBotLives.Name = "lblBotLives";
            lblBotLives.Size = new Size(50, 20);
            lblBotLives.TabIndex = 9;
            lblBotLives.Text = "label1";
            // 
            // lblPlayerLives
            // 
            lblPlayerLives.AutoSize = true;
            lblPlayerLives.BackColor = Color.Transparent;
            lblPlayerLives.ForeColor = SystemColors.ButtonHighlight;
            lblPlayerLives.Location = new Point(285, 9);
            lblPlayerLives.Name = "lblPlayerLives";
            lblPlayerLives.Size = new Size(50, 20);
            lblPlayerLives.TabIndex = 10;
            lblPlayerLives.Text = "label2";
            // 
            // picPlayerChoice
            // 
            picPlayerChoice.BackColor = Color.Transparent;
            picPlayerChoice.BackgroundImageLayout = ImageLayout.Stretch;
            picPlayerChoice.Location = new Point(284, 356);
            picPlayerChoice.Name = "picPlayerChoice";
            picPlayerChoice.Size = new Size(99, 120);
            picPlayerChoice.TabIndex = 11;
            picPlayerChoice.TabStop = false;
            // 
            // picCardHolder
            // 
            picCardHolder.BackColor = Color.Transparent;
            picCardHolder.Location = new Point(118, 345);
            picCardHolder.Name = "picCardHolder";
            picCardHolder.Size = new Size(160, 143);
            picCardHolder.TabIndex = 12;
            picCardHolder.TabStop = false;
            // 
            // picBotIdle
            // 
            picBotIdle.BackColor = Color.Transparent;
            picBotIdle.BackgroundImageLayout = ImageLayout.None;
            picBotIdle.Image = (Image)resources.GetObject("picBotIdle.Image");
            picBotIdle.Location = new Point(-42, 43);
            picBotIdle.Name = "picBotIdle";
            picBotIdle.Size = new Size(250, 258);
            picBotIdle.SizeMode = PictureBoxSizeMode.CenterImage;
            picBotIdle.TabIndex = 13;
            picBotIdle.TabStop = false;
            // 
            // picBotAttack
            // 
            picBotAttack.BackColor = Color.Transparent;
            picBotAttack.BackgroundImageLayout = ImageLayout.Stretch;
            picBotAttack.Image = (Image)resources.GetObject("picBotAttack.Image");
            picBotAttack.Location = new Point(-7, 32);
            picBotAttack.Name = "picBotAttack";
            picBotAttack.Size = new Size(412, 280);
            picBotAttack.SizeMode = PictureBoxSizeMode.StretchImage;
            picBotAttack.TabIndex = 14;
            picBotAttack.TabStop = false;
            // 
            // FormBattleField
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(395, 633);
            Controls.Add(btnSci);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Controls.Add(picBotAttack);
            Controls.Add(picCardHolder);
            Controls.Add(picPlayerChoice);
            Controls.Add(lblPlayerLives);
            Controls.Add(lblBotLives);
            Controls.Add(lblResult);
            Controls.Add(lblLives);
            Controls.Add(picEnemyChoice);
            Controls.Add(picBotIdle);
            Controls.Add(picIdle);
            Controls.Add(picAttack);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBattleField";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBattleField";
            Load += FormBattleField_Load;
            ((System.ComponentModel.ISupportInitialize)picIdle).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAttack).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEnemyChoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayerChoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCardHolder).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBotIdle).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBotAttack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox picIdle;
        private PictureBox picAttack;
        private Button btnRock;
        private Button btnPaper;
        private Button btnSci;
        private PictureBox picEnemyChoice;
        private Label lblLives;
        private Label lblResult;
        private Label lblBotLives;
        private Label lblPlayerLives;
        private PictureBox picPlayerChoice;
        private PictureBox picCardHolder;
        private PictureBox picBotIdle;
        private PictureBox picBotAttack;
        private ToolTip toolTipChoice;
    }
}