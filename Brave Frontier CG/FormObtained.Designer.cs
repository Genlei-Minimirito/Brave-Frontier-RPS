namespace Brave_Frontier_CG
{
    partial class FormObtained
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
            picPortrait = new PictureBox();
            lblCharName = new Label();
            btnContinue = new Button();
            lblMana = new Label();
            lblCoins = new Label();
            lblGems = new Label();
            lblName = new Label();
            ((System.ComponentModel.ISupportInitialize)picPortrait).BeginInit();
            SuspendLayout();
            // 
            // picPortrait
            // 
            picPortrait.BackColor = Color.Transparent;
            picPortrait.Image = Properties.Resources.ATRO;
            picPortrait.Location = new Point(39, 209);
            picPortrait.Name = "picPortrait";
            picPortrait.Size = new Size(328, 322);
            picPortrait.SizeMode = PictureBoxSizeMode.StretchImage;
            picPortrait.TabIndex = 0;
            picPortrait.TabStop = false;
            // 
            // lblCharName
            // 
            lblCharName.BackColor = Color.Transparent;
            lblCharName.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCharName.ForeColor = SystemColors.ButtonFace;
            lblCharName.Location = new Point(1, 112);
            lblCharName.Name = "lblCharName";
            lblCharName.Size = new Size(411, 74);
            lblCharName.TabIndex = 1;
            lblCharName.Text = "Deemo and the Girl";
            lblCharName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.Transparent;
            btnContinue.FlatStyle = FlatStyle.Popup;
            btnContinue.Location = new Point(106, 578);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(207, 59);
            btnContinue.TabIndex = 2;
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click_1;
            // 
            // lblMana
            // 
            lblMana.BackColor = Color.Transparent;
            lblMana.FlatStyle = FlatStyle.Popup;
            lblMana.Font = new Font("SimSun", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMana.ForeColor = SystemColors.ControlLightLight;
            lblMana.Location = new Point(310, 57);
            lblMana.Name = "lblMana";
            lblMana.Size = new Size(91, 17);
            lblMana.TabIndex = 32;
            lblMana.Text = "0";
            lblMana.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCoins
            // 
            lblCoins.BackColor = Color.Transparent;
            lblCoins.FlatStyle = FlatStyle.Popup;
            lblCoins.Font = new Font("SimSun", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCoins.ForeColor = SystemColors.ControlLightLight;
            lblCoins.Location = new Point(310, 40);
            lblCoins.Name = "lblCoins";
            lblCoins.Size = new Size(91, 17);
            lblCoins.TabIndex = 31;
            lblCoins.Text = "0";
            lblCoins.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGems
            // 
            lblGems.BackColor = Color.Transparent;
            lblGems.FlatStyle = FlatStyle.Popup;
            lblGems.Font = new Font("SimSun", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGems.ForeColor = SystemColors.ControlLightLight;
            lblGems.Location = new Point(310, 23);
            lblGems.Name = "lblGems";
            lblGems.Size = new Size(91, 17);
            lblGems.TabIndex = 30;
            lblGems.Text = "99999";
            lblGems.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            lblName.BackColor = Color.Transparent;
            lblName.FlatStyle = FlatStyle.Popup;
            lblName.Font = new Font("SimSun", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.ControlLightLight;
            lblName.Location = new Point(1, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(132, 19);
            lblName.TabIndex = 29;
            lblName.Text = "PlayerName";
            // 
            // FormObtained
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OBTAINED;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(413, 680);
            Controls.Add(lblMana);
            Controls.Add(lblCoins);
            Controls.Add(lblGems);
            Controls.Add(lblName);
            Controls.Add(btnContinue);
            Controls.Add(lblCharName);
            Controls.Add(picPortrait);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormObtained";
            Text = "FormObtained";
            ((System.ComponentModel.ISupportInitialize)picPortrait).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picPortrait;
        private Label lblCharName;
        private Button btnContinue;
        private Label lblMana;
        private Label lblCoins;
        private Label lblGems;
        private Label lblName;
    }
}